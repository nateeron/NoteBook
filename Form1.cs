
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using NoteBook.Models;
using System.Diagnostics;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace NoteBook
{
    public partial class Form1 : Form
    {

        private readonly string _configuration;
        private readonly string _vscodePath;

        public Form1(IConfiguration configuration)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ResizeRedraw = true;
            _configuration = configuration.GetConnectionString("SQLiteConnection");
            _vscodePath = configuration.GetConnectionString("vscode");
            List_data.DrawColumnHeader += List_data_DrawColumnHeader;
            List_data.DrawItem += List_data_DrawItem;

            EnsureDatabaseReady();
            GetSelectListData(null);
            GetListGroup();
        }


        private void List_data_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Set the header background color
            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(141, 141, 141)))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            // Draw the header text
            e.Graphics.DrawString(e.Header.Text, e.Font, Brushes.White, e.Bounds);
            e.DrawDefault = false; // Prevent default drawing
        }

        private void List_data_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Check if the item is selected
            if (e.Item.Selected)
            {

                //using (SolidBrush textBrush = new SolidBrush(Color.White)) // Change to desired text color
                //{
                //    e.Graphics.DrawString(e.Item.Text, e.Item.Font, textBrush, e.Bounds);
                //}
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(141, 141, 141)))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);

                }
                // Draw the header text

            }
            else
            {
                e.DrawDefault = true; // Default drawing for non-selected items
            }
            e.DrawDefault = true;


        }

        #region
        private void EnsureDatabaseReady()
        {
            // Extract the database path from the connection string
            string databasePath = _configuration.Split(';')[0].Split('=')[1];

            // Check if the database file exists
            if (!File.Exists(databasePath))
            {
                // If the database does not exist, create it by opening a connection
                using (var connection = new SQLiteConnection(_configuration))
                {
                    connection.Open();
                    // Close the connection to finalize the database file creation
                }
                CreateTable();
                CreateTableGroupNotebook();
            }

        }

        public void CreateTableGroupNotebook()
        {
            // Get the connection string from the configuration
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();

                string query = @"
                                CREATE TABLE IF NOT EXISTS Group_notebook (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    group_name TEXT NOT NULL,
                                    created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                                    updated_at TEXT DEFAULT CURRENT_TIMESTAMP
                                );";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public void CreateTable()
        {
            // Get the connection string from appsettings.json

            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();

                string query = @"
                                     CREATE TABLE IF NOT EXISTS notebook (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                name TEXT NOT NULL,
                                path_url TEXT,
                                user TEXT,
                                pass TEXT,
                                description TEXT,                        
                                GroupID INTEGER,
                                created_at TEXT DEFAULT CURRENT_TIMESTAMP,
                                updated_at TEXT DEFAULT CURRENT_TIMESTAMP
                                    );"
                                ;

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertNotebookEntry(string name, string pathUrl, string user, string pass, string description, int GroupID)
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();

                string query = @"
                    INSERT INTO notebook (name, path_url, user, pass, description,GroupID , created_at, updated_at)
                    VALUES (@name, @path_url, @user, @pass, @description, @GroupID, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@path_url", pathUrl);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@GroupID", GroupID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateNotebookEntry(int id, string name, string pathUrl, string user, string pass, string description, int GroupID)
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = @"
                            UPDATE notebook
                            SET name = @name, 
                                path_url = @path_url, 
                                user = @user, 
                                pass = @pass, 
                                description = @description,                           
                                GroupID = @GroupID,
                                updated_at = CURRENT_TIMESTAMP   -- Update the updated_at timestamp
                            WHERE id = @id;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@path_url", pathUrl);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@GroupID", GroupID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void GetListGroup()
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "SELECT * FROM Group_notebook;";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    // Set the display and value members for the ListBox
                    list_Group.DisplayMember = "GroupName";
                    list_Group.ValueMember = "Id";
                    select_Group.DisplayMember = "GroupName";
                    select_Group.ValueMember = "Id";
                    list_Group.Items.Clear();
                    select_Group.Items.Clear();

                    while (reader.Read())
                    {
                        // Create a new Group_s object
                        Group_s g = new Group_s();
                        g.Id = Convert.ToInt32(reader["id"]);
                        g.GroupName = reader["group_name"].ToString();

                        // Add the Group object to the ListBox
                        list_Group.Items.Add(g);
                        select_Group.Items.Add(g);
                    }
                }
            }
        }

        public void select_ItendataById(int id)
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "SELECT * FROM notebook WHERE id = @id ;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            txt_Name.Text = reader["name"].ToString();
                            txt_Path.Text = reader["path_url"].ToString();
                            txt_User.Text = reader["user"].ToString();
                            txt_Pass.Text = reader["pass"].ToString();
                            txt_desc.Text = reader["description"].ToString();

                            var GroupID = reader["GroupID"].ToString();
                            int selectedGroupId = Convert.ToInt32(GroupID);
                            //select_Group.SelectedValue = selectedGroupId;
                            //select_Group.SelectedItem = selectedGroupId;
                            for (int i = 0; i < select_Group.Items.Count; i++)
                            {
                                Group_s item = (Group_s)select_Group.Items[i];
                                if (item.Id == selectedGroupId)
                                {
                                    select_Group.SelectedIndex = i;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void GetSelectListData22(int? Group_id)
        {
            List_data.Items.Clear(); // Clear existing items before adding new ones

            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "";
                if (Group_id == null)
                {

                    query = "SELECT * FROM notebook "; // Use parameterized query to avoid SQL injection
                }
                else
                {
                    query = "SELECT * FROM notebook WHERE GroupID = @GroupID"; // Use parameterized query to avoid SQL injection

                }
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", Group_id); // Add parameter for GroupID

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a string with the formatted data
                            string displayText = reader["name"].ToString();
                            int id = Convert.ToInt32(reader["id"]); // Assuming ID is an integer

                            // Create a new ListViewItem
                            ListViewItem item = new ListViewItem(displayText);

                            // Set the Tag property to store the ID
                            item.Tag = id;
                            List_data.View = View.Details;
                            // Add the item to the ListView
                            List_data.Items.Add(item);
                            List_data.FullRowSelect = true;

                        }
                    }
                }
            }
        }

        public void GetSelectListData_D(int? Group_id)
        {
            // Clear existing items and columns before adding new ones
            List_data.Items.Clear();
            List_data.Columns.Clear();

            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "";

                if (Group_id == null)
                {
                    query = "SELECT * FROM notebook"; // No GroupID filter
                }
                else
                {
                    query = "SELECT * FROM notebook WHERE GroupID = @GroupID"; // Parameterized query
                }

                using (var command = new SQLiteCommand(query, connection))
                {
                    if (Group_id != null)
                    {
                        command.Parameters.AddWithValue("@GroupID", Group_id); // Add parameter for GroupID
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        // Define columns with specific widths
                        List_data.View = View.Details;
                        List_data.Columns.Add("Name", 200);
                        List_data.Columns.Add("Path", 270);
                        List_data.Columns.Add("User", 150);
                        List_data.Columns.Add("Pass", 100);

                        List_data.FullRowSelect = true; // Enable full row selection

                        while (reader.Read())
                        {
                            // Create a ListViewItem with the 'Name' column
                            ListViewItem item = new ListViewItem(reader["name"].ToString());

                            // Add subitems for other columns (Path, User, Pass)
                            item.SubItems.Add(reader["path_url"].ToString());
                            item.SubItems.Add(reader["user"].ToString());
                            item.SubItems.Add(reader["pass"].ToString());

                            // Store the ID in the Tag property for later use
                            item.Tag = Convert.ToInt32(reader["id"]);

                            // Add the ListViewItem to the ListView
                            List_data.Items.Add(item);
                        }
                    }
                }
            }
        }

        public string CheckString(string path)
        {
            if (path.Contains("http"))
                return "http";
            if (path.Contains(".sln"))
                return "vss";
            if (path.Contains(";vscode"))
                return "vscode";
            return "icon1"; // Default value if no keyword is found
        }


        public void GetSelectListData(int? Group_id)
        {
            // Clear existing items and columns before adding new ones
            List_data.Items.Clear();
            List_data.Columns.Clear();

            // Initialize and set up the ImageList
            var imageList = new ImageList();
            imageList.ImageSize = new Size(20, 20); // Set the size of the icons
            imageList.Images.Add("icon1", Image.FromFile("app_images/icon1-f.png")); // Load an icon
            imageList.Images.Add("http", Image.FromFile("app_images/http-f.png")); // Load another icon if needed
            imageList.Images.Add("vscode", Image.FromFile("app_images/vscode-f.png")); // Load another icon if needed
            imageList.Images.Add("vss", Image.FromFile("app_images/vss-f.png")); // Load another icon if needed

            // Assign the ImageList to the ListView
            List_data.SmallImageList = imageList;

            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = Group_id == null ? "SELECT * FROM notebook" : "SELECT * FROM notebook WHERE GroupID = @GroupID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    if (Group_id != null)
                    {
                        command.Parameters.AddWithValue("@GroupID", Group_id); // Add parameter for GroupID
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        // Define columns with specific widths
                        List_data.View = View.Details;
                        List_data.Columns.Add("Name", 200);
                        List_data.Columns.Add("Path", 270);
                        List_data.Columns.Add("User", 150);
                        List_data.Columns.Add("Pass", 100);
                        List_data.FullRowSelect = true; // Enable full row selection

                        while (reader.Read())
                        {
                            string path = reader["path_url"].ToString();
                            // Create a ListViewItem with the 'Name' column and assign an icon by index or key
                            var item = new ListViewItem(reader["name"].ToString())
                            {
                                ImageKey = CheckString(path), // Use the key or index of the icon from ImageList
                                Tag = Convert.ToInt32(reader["id"]) // Store the ID in the Tag property for later use
                            };

                            // Add subitems for other columns (Path, User, Pass)
                            item.SubItems.Add(path);
                            item.SubItems.Add(reader["user"].ToString());
                            item.SubItems.Add(reader["pass"].ToString());

                            // Add the ListViewItem to the ListView
                            List_data.Items.Add(item);
                        }
                    }
                }
            }
        }


        public void DeleteNotebookEntry(int id)
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "DELETE FROM notebook WHERE id = @id;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteNotebookAllinGroup(int id)
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "DELETE FROM notebook WHERE GroupID = @id;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteListGroup(int id)
        {
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = "DELETE FROM Group_notebook WHERE id = @id;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            DeleteNotebookAllinGroup(id);
        }

        #endregion


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("listView1_SelectedIndexChanged..............");
            // Check if an item is selected
            if (List_data.SelectedItems.Count > 0)
            {
                bt_add.Text = "Update";

                // Get the selected ListViewItem
                ListViewItem selectedItem = List_data.SelectedItems[0];

                // Retrieve the ID from the Tag property
                int id = (int)selectedItem.Tag; // Cast it back to int
                select_ItendataById(id);
                txt_id.Text = id.ToString();
                // Now you can use the ID as needed
                Debug.WriteLine("Selected ID: " + id);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

            if (select_Group.Text != "" && txt_Name.Text != "")
            {

                string txName = txt_Name.Text;
                string txtPath = txt_Path.Text;
                string txtUser = txt_User.Text;
                string txtPass = txt_Pass.Text;
                string txtdesc = txt_desc.Text;

                string selectedGroupName = select_Group.Text;
                int? select_GroupID = GetSelectedGroupID();
                List<string> gn = CheckDataGroupName(selectedGroupName);
                // If no group was selected, insert a new group
                int sd = gn.Count();
                if (select_GroupID == null && sd == 0)
                {
                    // Optionally prompt for a group name or use a default value
                    select_GroupID = InsertGroupNotebook(selectedGroupName);
                }
                if (txt_id.Text == "")
                {

                    // Insert the entry into the database
                    InsertNotebookEntry(txName, txtPath, txtUser, txtPass, txtdesc, select_GroupID.Value);

                }
                else
                {
                    int id_ = Convert.ToInt32(txt_id.Text);
                    UpdateNotebookEntry(id_, txName, txtPath, txtUser, txtPass, txtdesc, select_GroupID.Value);
                }

                // Optionally clear the input fields after insertion
                txt_Name.Clear();
                txt_Path.Clear();
                txt_User.Clear();
                txt_Pass.Clear();
                txt_desc.Clear();

                // Optionally reload the notebook entries in the ListView
                GetSelectListData(null);
                GetListGroup();
            }


        }
        private int? GetSelectedGroupID()
        {

            if (select_Group.SelectedItem != null)
            {
                Group_s gid = (Group_s)select_Group.SelectedItem;
                return gid.Id;  // Return the selected group ID if valid
            }

            return null;  // Return null if no valid group is selected
        }

        // Function to insert a new group into the Group_notebook table
        public int InsertGroupNotebook(string groupName)
        {
            int groupId = -1;
            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = @"
                        INSERT INTO Group_notebook (group_name, created_at, updated_at)
                        VALUES (@group_name, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);
                        SELECT last_insert_rowid();";  // Get the last inserted group ID

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@group_name", groupName);
                    groupId = Convert.ToInt32(command.ExecuteScalar());  // Get the inserted GroupID
                }
            }
            return groupId;  // Return the new group ID
        }
        private void select_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("select_Group_SelectedIndexChanged..............");
        }

        public List<string> CheckDataGroupName(string groupName)
        {
            List<string> list = new List<string>();

            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query = @"SELECT group_name FROM Group_notebook WHERE group_name = @group_name";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@group_name", groupName);

                    using (var reader = command.ExecuteReader())  // Use ExecuteReader to read multiple rows
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(0));  // Add each group_name to the list
                        }
                    }
                }
            }
            return list;  // Return the list of matching group names
        }

        private void list_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Group.SelectedItem != null)
            {
                bt_add.Text = "Save";
                // select_Group.Text = "";
                Group_s listGroup = new Group_s();
                listGroup = (Group_s)list_Group.SelectedItem;
                //select_Group.Text = listGroup.GroupName;
                txt_id.Clear();
                // Optionally clear the input fields after insertion
                txt_Name.Clear();
                txt_Path.Clear();
                txt_User.Clear();
                txt_Pass.Clear();
                txt_desc.Clear();
               
                GetSelectListData(listGroup.Id);
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            reset();


        }

        private void reset()
        {
            select_Group.SelectedIndex= 0;
            bt_add.Text = "Save";
            txt_id.Clear();
            // Optionally clear the input fields after insertion
            txt_Name.Clear();
            txt_Path.Clear();
            txt_User.Clear();
            txt_Pass.Clear();
            txt_desc.Clear();

            // Optionally reload the notebook entries in the ListView
            // LoadNotebookEntries();

            GetSelectListData(null);
            GetListGroup();


        }



        private void List_data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Check if any item is selected
            if (List_data.SelectedItems.Count > 0)
            {
                string path = txt_Path.Text;


                if (path.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || path.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        // Use ProcessStartInfo to open the URL in the default browser
                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = path,
                            UseShellExecute = true  // This ensures the OS opens it with the default browser
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to open URL: {ex.Message}");
                    }
                }
                else
                {
                    if (path.Contains(";vscode", StringComparison.OrdinalIgnoreCase))
                    //  if (path.StartsWith(":vscode", StringComparison.OrdinalIgnoreCase))
                    {
                        string folderPath = path.Split(";")[0].Trim();
                        OpenFolderInVSCode(folderPath);
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = path,
                            UseShellExecute = true // This is necessary to open folders
                        });
                    }

                }
            }
        }

        private void OpenFolderInVSCode(string path)
        {
            try
            {

                // Start the process with the specified folder path
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = _vscodePath,
                    Arguments = $"\"{path}\"", // Use quotes to handle spaces in the path
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening folder in VS Code: " + ex.Message);
            }
        }

        private void bt_copy_pass_Click(object sender, EventArgs e)
        {
            string password = txt_Pass.Text; // Adjust index if necessary
            if (password != "")
            {
                Clipboard.SetText(password);

            }

        }

        private void bt_copy_User_Click(object sender, EventArgs e)
        {
            string User = txt_User.Text; // Adjust index if necessary
            // Copy the password to the clipboard
            if (User != "")
            {
                Clipboard.SetText(User);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Maximize the application
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Minimize the application
            this.WindowState = FormWindowState.Minimized;
        }
        private bool dragging = false;
        private Point dragCursor;
        private Point dragForm;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursor));
                this.Location = Point.Add(dragForm, (Size)dif);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void txt_shearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_shearch.Text; // Get the current text in the TextBox
            Search(searchText);

        }



        public void Search(string text)
        {
            // Clear existing items and columns before adding new ones
            List_data.Items.Clear();
            List_data.Columns.Clear();

            string Group_id = ""; // Group ID filter - set as required

            using (var connection = new SQLiteConnection(_configuration))
            {
                connection.Open();
                string query;

                if (string.IsNullOrEmpty(Group_id))
                {
                    query = "SELECT * FROM notebook WHERE name LIKE @SearchText OR path_url LIKE @SearchText OR user LIKE @SearchText OR description LIKE @SearchText";
                }
                else
                {
                    query = "SELECT * FROM notebook WHERE GroupID = @GroupID AND (name LIKE @SearchText OR path_url LIKE @SearchText OR user LIKE @SearchText OR description LIKE @SearchText)";
                }

                using (var command = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(Group_id))
                    {
                        command.Parameters.AddWithValue("@GroupID", Group_id);
                    }

                    command.Parameters.AddWithValue("@SearchText", $"{text}%"); // Parameterize the search text

                    using (var reader = command.ExecuteReader())
                    {
                        // Define columns with specific widths
                        List_data.View = View.Details;
                        List_data.Columns.Add("Name", 200);
                        List_data.Columns.Add("Path", 270);
                        List_data.Columns.Add("User", 150);
                        List_data.Columns.Add("Pass", 100);

                        List_data.FullRowSelect = true; // Enable full row selection

                        while (reader.Read())
                        {
                            // Create a ListViewItem with the 'Name' column
                            ListViewItem item = new ListViewItem(reader["name"].ToString());

                            // Add subitems for other columns (Path, User, Pass)
                            item.SubItems.Add(reader["path_url"].ToString());
                            item.SubItems.Add(reader["user"].ToString());
                            item.SubItems.Add(reader["pass"].ToString());

                            // Store the ID in the Tag property for later use
                            item.Tag = Convert.ToInt32(reader["id"]);

                            // Add the ListViewItem to the ListView
                            List_data.Items.Add(item);
                        }
                    }
                }
            }
        }


        private void list_Group_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (list_Group.SelectedItem != null)
                {
                    // Show a confirmation dialog with Yes and No buttons
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Delete Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                    // Check if the user clicked 'Yes'
                    if (result == DialogResult.Yes)
                    {


                        Group_s listGroup = (Group_s)list_Group.SelectedItem;
                        int id = Convert.ToInt32(listGroup.Id);
                        DeleteListGroup(id);
                        reset();


                    }
                    else
                    {
                        // User clicked 'No', do nothing or cancel the action
                        MessageBox.Show("Deletion cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }




            }
        }

        private void List_data_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if an item is selected
            if (List_data.SelectedItems.Count > 0)
            {
                // Show a confirmation dialog with Yes and No buttons
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                  "Delete Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                // Check if the user clicked 'Yes'
                if (result == DialogResult.Yes)
                {

                    // Get the selected ListViewItem
                    ListViewItem selectedItem = List_data.SelectedItems[0];

                    // Retrieve the ID from the Tag property
                    int id = (int)selectedItem.Tag; // Cast it back to int
                    DeleteNotebookEntry(id);
                    GetSelectListData(null);
                    // Now you can use the ID as needed

                }
                else
                {
                    // User clicked 'No', do nothing or cancel the action
                    MessageBox.Show("Deletion cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void bt_clearShearch_Click(object sender, EventArgs e)
        {
            txt_shearch.Text = string.Empty;
        }
    }
}