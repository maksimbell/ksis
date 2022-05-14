using Common.FileHandling;
using Common.Helpers;
using RESTfulFileService.ResponseExceptions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;

namespace RESTfulFileService
{
    public class ResourceRequestHandler
    {
        public delegate void RequestHandler(HttpListenerContext ctx);
        private readonly FileStorage storage = new FileStorage();
        private readonly Dictionary<FileOperations, RequestHandler> actions;

        public ResourceRequestHandler()
        {
            actions = new Dictionary<FileOperations, RequestHandler>() {
                { FileOperations.CREATE, Post },
                { FileOperations.READ, Read },
                { FileOperations.DELETE, Delete },
                { FileOperations.INFO, GetInfo},
                { FileOperations.PUT, Rewrite},
                { FileOperations.PATCH, Rename},
                //{ FileOperations.COPY, Copy}
            };
        }

        public void Perform(HttpListenerContext ctx)
        {
            try
            {
                RequestHandler requestHandler = ResolveRequestHandler(ctx.Request);
                requestHandler(ctx);
            }
            catch (MethodNotImplementedException)
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
            }
            catch (BadRequestException)
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            ctx.Response.Close();
        }

        public RequestHandler ResolveRequestHandler(HttpListenerRequest req)
        {
            string httpMethod = req.HttpMethod;
            Console.WriteLine(httpMethod);
            var operationType = httpMethod switch
            {
                "GET" => FileOperations.READ,
                "POST" => FileOperations.CREATE,
                "DELETE" => FileOperations.DELETE,
                "HEAD" => FileOperations.INFO,
                "PUT" => FileOperations.PUT,
                "PATCH" => FileOperations.PATCH,
                //"COPY" => FileOperations.COPY,
                _ => throw new MethodNotImplementedException(),
            };

            return actions[operationType];
        }

        public void Post(HttpListenerContext ctx)
        {
            var query = string.Format(ctx.Request.RawUrl).Split("/")[2];

            switch(query)
            {
                case "create":
                    {
                        this.Create(ctx);
                        break;
                    }

                case "copy":
                    {
                        this.Copy(ctx);
                        break;
                    }
            }
        }

        private void Create(HttpListenerContext ctx)
        {
            NameValueCollection headers = ctx.Request.Headers;
            string name;
            try
            {
                name = HttpRequestHelper.GetHeaderByKey(headers, "Name");
            }
            catch (Exception e)
            {
                throw new BadRequestException(e.Message);
            }

            FileEntity file = new FileEntity(name, FileService.ConvertToByteArray(ctx.Request.InputStream));
            storage.AddFile(file);

            ctx.Response.AppendHeader("Id", file.Id);
            ctx.Response.StatusCode = (int)HttpStatusCode.Created;
            //ctx.Response.Close();
        }

        public void Read(HttpListenerContext ctx)
        {
            string resourceId = ctx.Request.Url.Segments[2];

            if (storage.HasFile(resourceId))
            {
                FileEntity fileEntity = storage.GetFile(resourceId);

                ctx.Response.AppendHeader("Name", fileEntity.UserDefinedName);
                ctx.Response.StatusCode = (int)HttpStatusCode.OK;
                FileService.WriteBytesToResponseBody(fileEntity.Data, ctx.Response);
            }
            else
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            ctx.Response.Close();
        }

        public void Delete(HttpListenerContext ctx)
        {
            string resourceId = ctx.Request.Url.Segments[2];

            if (storage.HasFile(resourceId))
            {
                storage.DeleteFile(resourceId);
                ctx.Response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            ctx.Response.Close();
        }

        public void GetInfo(HttpListenerContext ctx)
        {
            string resourceId = ctx.Request.Url.Segments[2];

            if (storage.HasFile(resourceId))
            {
                FileEntity file = storage.GetFile(resourceId);
                ctx.Response.AppendHeader("Name", file.UserDefinedName);
                ctx.Response.AppendHeader("Size", file.Size.ToString());
                ctx.Response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            ctx.Response.Close();
        }

        public void Rewrite(HttpListenerContext ctx)
        {
            string resourceId = ctx.Request.Url.Segments[2];

            NameValueCollection headers = ctx.Request.Headers;
            string name;
            try
            {
                name = HttpRequestHelper.GetHeaderByKey(headers, "Name");
            }
            catch (Exception e)
            {
                throw new BadRequestException(e.Message);
            }

            FileEntity file = new FileEntity(name, FileService.ConvertToByteArray(ctx.Request.InputStream));

            try
            {
                storage.AddFile(file);
                storage.DeleteFile(resourceId);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ctx.Response.AppendHeader("Id", file.Id);
            ctx.Response.StatusCode = (int)HttpStatusCode.Created;

            ctx.Response.Close();
        }

        public void Rename(HttpListenerContext ctx)
        {
            string resourceId = ctx.Request.Url.Segments[2];

            NameValueCollection headers = ctx.Request.Headers;
            string name;
            try
            {
                name = HttpRequestHelper.GetHeaderByKey(headers, "Name");
            }
            catch (Exception e)
            {
                throw new BadRequestException(e.Message);
            }

            if (storage.HasFile(resourceId))
            {
                FileEntity file = storage.GetFile(resourceId);
                file.UserDefinedName = name;

                ctx.Response.AppendHeader("New-Name", file.UserDefinedName);
                ctx.Response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }

            ctx.Response.Close();
        }

        public void Copy(HttpListenerContext ctx)
        {
            string resourceId = ctx.Request.Url.Segments[^1];

            if (storage.HasFile(resourceId))
            {
                FileEntity file = storage.GetFile(resourceId);
                FileEntity fileCopy = new FileEntity(file.UserDefinedName, file.Data);
                storage.AddFile(fileCopy);

                ctx.Response.AppendHeader("Copy-Id", fileCopy.Id);
                ctx.Response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }

            ctx.Response.Close();
        }
    }
}
