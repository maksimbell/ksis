using Common;
using Common.FileHandling;
using Common.Helpers;
using System.Threading.Tasks;

namespace Client
{
    public partial class ClientForm : Form
    {
        private const string MSG_DELETE_SUCCESS = "{0}: successfully deleted!";
        private const string MSG_DELETE_FAILURE = "{0}: delete failed!";
        private const string MSG_UPLOAD_SUCCESS = "{0}: successfully uploaded!";
        private const string MSG_UPLOAD_FAILURE = "{0}: upload failed!";
        private const string MSG_GET_SUCCESS = "{0}: sucessfulley downloaded!";
        private const string MSG_GET_FAILURE = "{0}: download failed!";

        private readonly CustomHttpClient httpClient = CustomHttpClient.GetInstance();
        private readonly List<ClientUploadedFile> uploadedFiles = new List<ClientUploadedFile>();

        private bool isFileLoading = false;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = FileHelper.GetFileName(openFileDialog.FileName);
                var file = new ClientUploadedFile(filename)
                {
                    Data = File.ReadAllBytes(openFileDialog.FileName)
                };

                uploadedFiles.Add(file);

                await Task.Run(() => UploadAsync(file));
            }
        }

        public void UpdateUploadedFilesListSafe()
        {
            if (cbResId.InvokeRequired)
            {
                cbResId.Invoke(new Action(UpdateUploadedFilesListSafe));
            }
            else
            {

                //btnSend.Enabled = !isFileLoading;
                //cbCurrentAttachments.Items.Clear();
                //uploadedFiles.ForEach(file => cbCurrentAttachments.Items.Add(file));
            }
        }

        private async void UploadAsync(ClientUploadedFile file)
        {
            var response = await httpClient.PostAsync(file, "create");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(string.Format(MSG_UPLOAD_SUCCESS, file.FullName));
                file.Uploaded = true;
                file.ResourceId = HttpRequestHelper.GetHeaderByKey(response.Headers, "Id");

                cbResId.Items.Add(file.ResourceId);
                cbResId.Text = file.ResourceId;
            }
            else
            {
                MessageBox.Show(string.Format(MSG_UPLOAD_FAILURE, response.StatusCode));
            }

            //isFileLoading = false;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbResId.SelectedIndex.ToString());
            MessageBox.Show(uploadedFiles.Count.ToString());

            ClientUploadedFile file = uploadedFiles[cbResId.SelectedIndex];
            HttpResponseMessage response = await CustomHttpClient.GetInstance().GetAsync(file.ResourceId);

            if (response.IsSuccessStatusCode)
            {
                file.Data = await FileService.ReadContentAsBytesAsync(response.Content);
                //file.Name = "sd";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FileService.WriteBytesByPath(
                        Path.Combine(folderBrowserDialog.SelectedPath, file.FullName), file.Data);
                    MessageBox.Show(string.Format(MSG_GET_SUCCESS, file.FullName));
                }
            }
            else
            {
                MessageBox.Show(string.Format(MSG_GET_FAILURE, file.FullName));
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbResId.SelectedIndex.ToString());
            MessageBox.Show(uploadedFiles.Count.ToString());
            ClientUploadedFile file = uploadedFiles[cbResId.SelectedIndex];
            HttpResponseMessage response = await httpClient.DeleteAsync(file.ResourceId);

            if (response.IsSuccessStatusCode)
            {
                uploadedFiles.RemoveAll(currentFile => currentFile.ResourceId == file.ResourceId);
                MessageBox.Show(string.Format(MSG_DELETE_SUCCESS, file.FullName));

                cbResId.Items.Remove(cbResId.SelectedItem);
                //cbResId.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(string.Format(MSG_DELETE_FAILURE, file.FullName));
            }
        }

        private async void btnReplace_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbResId.SelectedIndex.ToString());
            MessageBox.Show(uploadedFiles.Count.ToString());
            ClientUploadedFile fileToDelete = uploadedFiles[cbResId.SelectedIndex];

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = FileHelper.GetFileName(openFileDialog.FileName);
                var fileToAdd = new ClientUploadedFile(filename)
                {
                    Data = File.ReadAllBytes(openFileDialog.FileName)
                };

                uploadedFiles.Remove(fileToDelete);
                cbResId.Items.RemoveAt(cbResId.SelectedIndex);
                uploadedFiles.Add(fileToAdd);

                HttpResponseMessage response = await httpClient.PutAsync(fileToAdd, fileToDelete.ResourceId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(string.Format(MSG_UPLOAD_SUCCESS, fileToAdd.FullName));
                    fileToAdd.Uploaded = true;
                    fileToAdd.ResourceId = HttpRequestHelper.GetHeaderByKey(response.Headers, "Id");

                    cbResId.Items.Add(fileToAdd.ResourceId);
                    cbResId.Text = fileToAdd.ResourceId;
                }
                else
                {
                    MessageBox.Show(string.Format(MSG_UPLOAD_FAILURE, response.StatusCode));
                }

            }

        }

        private async void btnRename_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbResId.SelectedIndex.ToString());
            MessageBox.Show(uploadedFiles.Count.ToString());

            ClientUploadedFile file = uploadedFiles[cbResId.SelectedIndex];

            HttpResponseMessage response = await httpClient.PatchAsync(file.ResourceId, tbNewName.Text);

            file.Name = HttpRequestHelper.GetHeaderByKey(response.Headers, "New-Name");
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbResId.SelectedIndex.ToString());
            MessageBox.Show(uploadedFiles.Count.ToString());
            ClientUploadedFile file = uploadedFiles[cbResId.SelectedIndex];

            //MessageBox.Show(string.Format(MSG_UPLOAD_FAILURE, response.StatusCode));

            HttpResponseMessage response = await httpClient.PostAsync(string.Format("{0}/{1}", "copy", file.ResourceId));

            var copyId = HttpRequestHelper.GetHeaderByKey(response.Headers, "Copy-Id");

            var copyFile = new ClientUploadedFile(uploadedFiles[0]);
            copyFile.ResourceId = copyId;
            uploadedFiles.Add(copyFile);

            cbResId.Items.Add(copyId);
        }
    }
}