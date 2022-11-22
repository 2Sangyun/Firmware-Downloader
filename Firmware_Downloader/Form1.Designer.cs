
namespace Firmware_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.cmb_baud_rate = new System.Windows.Forms.ComboBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_baud_rate = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.cmb_data = new System.Windows.Forms.ComboBox();
            this.cmb_parity = new System.Windows.Forms.ComboBox();
            this.lbl_parity = new System.Windows.Forms.Label();
            this.cmb_stop_bits = new System.Windows.Forms.ComboBox();
            this.lbl_stop_bits = new System.Windows.Forms.Label();
            this.cmb_flow_control = new System.Windows.Forms.ComboBox();
            this.lbl_flow_control = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.grp_port = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ofd_file_explorer = new System.Windows.Forms.OpenFileDialog();
            this.txt_file_name = new System.Windows.Forms.TextBox();
            this.grp_file = new System.Windows.Forms.GroupBox();
            this.lbl_file_size = new System.Windows.Forms.Label();
            this.txt_file_size = new System.Windows.Forms.TextBox();
            this.lbl_base_address = new System.Windows.Forms.Label();
            this.txt_base_address = new System.Windows.Forms.TextBox();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.lvwFileData = new System.Windows.Forms.ListView();
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_file_content = new System.Windows.Forms.GroupBox();
            this.btn_write = new System.Windows.Forms.Button();
            this.grp_device = new System.Windows.Forms.GroupBox();
            this.btn_device_connect = new System.Windows.Forms.Button();
            this.lbl_device_id = new System.Windows.Forms.Label();
            this.txt_device_id = new System.Windows.Forms.TextBox();
            this.lbl_bl_version = new System.Windows.Forms.Label();
            this.txt_bl_version = new System.Windows.Forms.TextBox();
            this.tim_Connect = new System.Windows.Forms.Timer(this.components);
            this.grp_port.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grp_file.SuspendLayout();
            this.grp_file_content.SuspendLayout();
            this.grp_device.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_port
            // 
            this.cmb_port.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_port.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(914, 78);
            this.cmb_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(134, 20);
            this.cmb_port.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_open.Location = new System.Drawing.Point(132, 202);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(64, 32);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // cmb_baud_rate
            // 
            this.cmb_baud_rate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_baud_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_baud_rate.FormattingEnabled = true;
            this.cmb_baud_rate.Location = new System.Drawing.Point(914, 103);
            this.cmb_baud_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_baud_rate.Name = "cmb_baud_rate";
            this.cmb_baud_rate.Size = new System.Drawing.Size(134, 20);
            this.cmb_baud_rate.TabIndex = 3;
            // 
            // lbl_port
            // 
            this.lbl_port.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_port.Location = new System.Drawing.Point(22, 42);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(46, 18);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "Port:";
            // 
            // lbl_baud_rate
            // 
            this.lbl_baud_rate.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_baud_rate.Location = new System.Drawing.Point(22, 68);
            this.lbl_baud_rate.Name = "lbl_baud_rate";
            this.lbl_baud_rate.Size = new System.Drawing.Size(95, 18);
            this.lbl_baud_rate.TabIndex = 5;
            this.lbl_baud_rate.Text = "Baud Rate:";
            // 
            // lbl_data
            // 
            this.lbl_data.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_data.Location = new System.Drawing.Point(22, 94);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(54, 18);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "Data:";
            // 
            // cmb_data
            // 
            this.cmb_data.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_data.FormattingEnabled = true;
            this.cmb_data.Location = new System.Drawing.Point(914, 129);
            this.cmb_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_data.Name = "cmb_data";
            this.cmb_data.Size = new System.Drawing.Size(134, 20);
            this.cmb_data.TabIndex = 7;
            // 
            // cmb_parity
            // 
            this.cmb_parity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_parity.FormattingEnabled = true;
            this.cmb_parity.Location = new System.Drawing.Point(914, 154);
            this.cmb_parity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_parity.Name = "cmb_parity";
            this.cmb_parity.Size = new System.Drawing.Size(134, 20);
            this.cmb_parity.TabIndex = 9;
            // 
            // lbl_parity
            // 
            this.lbl_parity.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_parity.Location = new System.Drawing.Point(22, 119);
            this.lbl_parity.Name = "lbl_parity";
            this.lbl_parity.Size = new System.Drawing.Size(61, 18);
            this.lbl_parity.TabIndex = 8;
            this.lbl_parity.Text = "Parity:";
            // 
            // cmb_stop_bits
            // 
            this.cmb_stop_bits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_stop_bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stop_bits.FormattingEnabled = true;
            this.cmb_stop_bits.Location = new System.Drawing.Point(914, 179);
            this.cmb_stop_bits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_stop_bits.Name = "cmb_stop_bits";
            this.cmb_stop_bits.Size = new System.Drawing.Size(134, 20);
            this.cmb_stop_bits.TabIndex = 11;
            // 
            // lbl_stop_bits
            // 
            this.lbl_stop_bits.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_stop_bits.Location = new System.Drawing.Point(22, 144);
            this.lbl_stop_bits.Name = "lbl_stop_bits";
            this.lbl_stop_bits.Size = new System.Drawing.Size(85, 18);
            this.lbl_stop_bits.TabIndex = 10;
            this.lbl_stop_bits.Text = "Stop bits:";
            // 
            // cmb_flow_control
            // 
            this.cmb_flow_control.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_flow_control.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_flow_control.FormattingEnabled = true;
            this.cmb_flow_control.Location = new System.Drawing.Point(914, 204);
            this.cmb_flow_control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_flow_control.Name = "cmb_flow_control";
            this.cmb_flow_control.Size = new System.Drawing.Size(134, 20);
            this.cmb_flow_control.TabIndex = 13;
            // 
            // lbl_flow_control
            // 
            this.lbl_flow_control.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_flow_control.Location = new System.Drawing.Point(22, 169);
            this.lbl_flow_control.Name = "lbl_flow_control";
            this.lbl_flow_control.Size = new System.Drawing.Size(106, 18);
            this.lbl_flow_control.TabIndex = 12;
            this.lbl_flow_control.Text = "Flow control:";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(202, 202);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(64, 32);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grp_port
            // 
            this.grp_port.Controls.Add(this.btn_close);
            this.grp_port.Controls.Add(this.btn_open);
            this.grp_port.Controls.Add(this.lbl_baud_rate);
            this.grp_port.Controls.Add(this.lbl_data);
            this.grp_port.Controls.Add(this.lbl_parity);
            this.grp_port.Controls.Add(this.lbl_stop_bits);
            this.grp_port.Controls.Add(this.lbl_flow_control);
            this.grp_port.Controls.Add(this.lbl_port);
            this.grp_port.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.grp_port.Location = new System.Drawing.Point(782, 36);
            this.grp_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_port.Name = "grp_port";
            this.grp_port.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_port.Size = new System.Drawing.Size(282, 250);
            this.grp_port.TabIndex = 18;
            this.grp_port.TabStop = false;
            this.grp_port.Text = "Port설정";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openFileToolStripMenuItem.Text = "Open File(&O)";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // ofd_file_explorer
            // 
            this.ofd_file_explorer.FileName = "파일 이름";
            this.ofd_file_explorer.Filter = "Hex 파일(*.hex)|*.hex|bin 파일 (*.bin)|*.bin";
            this.ofd_file_explorer.InitialDirectory = "C:\\Users\\yoojihyeon\\Desktop";
            this.ofd_file_explorer.Title = "Open File";
            // 
            // txt_file_name
            // 
            this.txt_file_name.Location = new System.Drawing.Point(106, 34);
            this.txt_file_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_file_name.MaxLength = 100;
            this.txt_file_name.Name = "txt_file_name";
            this.txt_file_name.ReadOnly = true;
            this.txt_file_name.Size = new System.Drawing.Size(218, 24);
            this.txt_file_name.TabIndex = 22;
            this.txt_file_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_file_name_MouseDown);
            // 
            // grp_file
            // 
            this.grp_file.Controls.Add(this.lbl_file_size);
            this.grp_file.Controls.Add(this.txt_file_size);
            this.grp_file.Controls.Add(this.lbl_base_address);
            this.grp_file.Controls.Add(this.txt_base_address);
            this.grp_file.Controls.Add(this.lbl_file_name);
            this.grp_file.Controls.Add(this.txt_file_name);
            this.grp_file.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.grp_file.Location = new System.Drawing.Point(414, 36);
            this.grp_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_file.Name = "grp_file";
            this.grp_file.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_file.Size = new System.Drawing.Size(342, 154);
            this.grp_file.TabIndex = 23;
            this.grp_file.TabStop = false;
            this.grp_file.Text = "File";
            // 
            // lbl_file_size
            // 
            this.lbl_file_size.AutoSize = true;
            this.lbl_file_size.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_file_size.Location = new System.Drawing.Point(20, 110);
            this.lbl_file_size.Name = "lbl_file_size";
            this.lbl_file_size.Size = new System.Drawing.Size(79, 14);
            this.lbl_file_size.TabIndex = 28;
            this.lbl_file_size.Text = "파일 크기:";
            // 
            // txt_file_size
            // 
            this.txt_file_size.Location = new System.Drawing.Point(106, 105);
            this.txt_file_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_file_size.Name = "txt_file_size";
            this.txt_file_size.Size = new System.Drawing.Size(218, 24);
            this.txt_file_size.TabIndex = 27;
            // 
            // lbl_base_address
            // 
            this.lbl_base_address.AutoSize = true;
            this.lbl_base_address.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_base_address.Location = new System.Drawing.Point(20, 73);
            this.lbl_base_address.Name = "lbl_base_address";
            this.lbl_base_address.Size = new System.Drawing.Size(79, 14);
            this.lbl_base_address.TabIndex = 26;
            this.lbl_base_address.Text = "시작 주소:";
            // 
            // txt_base_address
            // 
            this.txt_base_address.Enabled = false;
            this.txt_base_address.Location = new System.Drawing.Point(106, 68);
            this.txt_base_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_base_address.Name = "txt_base_address";
            this.txt_base_address.Size = new System.Drawing.Size(218, 24);
            this.txt_base_address.TabIndex = 25;
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_file_name.Location = new System.Drawing.Point(20, 36);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(49, 14);
            this.lbl_file_name.TabIndex = 24;
            this.lbl_file_name.Text = "파일: ";
            // 
            // lvwFileData
            // 
            this.lvwFileData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAddress});
            this.lvwFileData.HideSelection = false;
            this.lvwFileData.Location = new System.Drawing.Point(69, 22);
            this.lvwFileData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwFileData.Name = "lvwFileData";
            this.lvwFileData.Size = new System.Drawing.Size(819, 225);
            this.lvwFileData.TabIndex = 24;
            this.lvwFileData.UseCompatibleStateImageBehavior = false;
            this.lvwFileData.View = System.Windows.Forms.View.Details;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 113;
            // 
            // grp_file_content
            // 
            this.grp_file_content.Controls.Add(this.btn_write);
            this.grp_file_content.Controls.Add(this.lvwFileData);
            this.grp_file_content.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.grp_file_content.Location = new System.Drawing.Point(23, 305);
            this.grp_file_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_file_content.Name = "grp_file_content";
            this.grp_file_content.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_file_content.Size = new System.Drawing.Size(1041, 257);
            this.grp_file_content.TabIndex = 25;
            this.grp_file_content.TabStop = false;
            this.grp_file_content.Text = "File Content";
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(913, 201);
            this.btn_write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(111, 38);
            this.btn_write.TabIndex = 30;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // grp_device
            // 
            this.grp_device.Controls.Add(this.btn_device_connect);
            this.grp_device.Controls.Add(this.lbl_device_id);
            this.grp_device.Controls.Add(this.txt_device_id);
            this.grp_device.Controls.Add(this.lbl_bl_version);
            this.grp_device.Controls.Add(this.txt_bl_version);
            this.grp_device.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.grp_device.Location = new System.Drawing.Point(92, 36);
            this.grp_device.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_device.Name = "grp_device";
            this.grp_device.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_device.Size = new System.Drawing.Size(305, 154);
            this.grp_device.TabIndex = 29;
            this.grp_device.TabStop = false;
            this.grp_device.Text = "Device";
            // 
            // btn_device_connect
            // 
            this.btn_device_connect.Enabled = false;
            this.btn_device_connect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_device_connect.Location = new System.Drawing.Point(199, 112);
            this.btn_device_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_device_connect.Name = "btn_device_connect";
            this.btn_device_connect.Size = new System.Drawing.Size(92, 28);
            this.btn_device_connect.TabIndex = 30;
            this.btn_device_connect.Text = "Connect";
            this.btn_device_connect.UseVisualStyleBackColor = true;
            this.btn_device_connect.Click += new System.EventHandler(this.btn_device_connect_Click);
            // 
            // lbl_device_id
            // 
            this.lbl_device_id.AutoSize = true;
            this.lbl_device_id.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_device_id.Location = new System.Drawing.Point(13, 36);
            this.lbl_device_id.Name = "lbl_device_id";
            this.lbl_device_id.Size = new System.Drawing.Size(85, 14);
            this.lbl_device_id.TabIndex = 31;
            this.lbl_device_id.Text = "Device ID:";
            // 
            // txt_device_id
            // 
            this.txt_device_id.Enabled = false;
            this.txt_device_id.Location = new System.Drawing.Point(164, 34);
            this.txt_device_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_device_id.Name = "txt_device_id";
            this.txt_device_id.Size = new System.Drawing.Size(126, 24);
            this.txt_device_id.TabIndex = 30;
            // 
            // lbl_bl_version
            // 
            this.lbl_bl_version.AutoSize = true;
            this.lbl_bl_version.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_bl_version.Location = new System.Drawing.Point(13, 73);
            this.lbl_bl_version.Name = "lbl_bl_version";
            this.lbl_bl_version.Size = new System.Drawing.Size(129, 14);
            this.lbl_bl_version.TabIndex = 33;
            this.lbl_bl_version.Text = "BootLoader Ver:";
            // 
            // txt_bl_version
            // 
            this.txt_bl_version.Enabled = false;
            this.txt_bl_version.Location = new System.Drawing.Point(164, 70);
            this.txt_bl_version.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bl_version.Name = "txt_bl_version";
            this.txt_bl_version.Size = new System.Drawing.Size(126, 24);
            this.txt_bl_version.TabIndex = 32;
            // 
            // tim_Connect
            // 
            this.tim_Connect.Interval = 10;
            this.tim_Connect.Tick += new System.EventHandler(this.ConnectTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 583);
            this.Controls.Add(this.grp_device);
            this.Controls.Add(this.grp_file_content);
            this.Controls.Add(this.grp_file);
            this.Controls.Add(this.cmb_flow_control);
            this.Controls.Add(this.cmb_stop_bits);
            this.Controls.Add(this.cmb_parity);
            this.Controls.Add(this.cmb_data);
            this.Controls.Add(this.cmb_baud_rate);
            this.Controls.Add(this.cmb_port);
            this.Controls.Add(this.grp_port);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "FirmwareDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_port.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_file.ResumeLayout(false);
            this.grp_file.PerformLayout();
            this.grp_file_content.ResumeLayout(false);
            this.grp_device.ResumeLayout(false);
            this.grp_device.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox cmb_baud_rate;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_baud_rate;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.ComboBox cmb_data;
        private System.Windows.Forms.ComboBox cmb_parity;
        private System.Windows.Forms.Label lbl_parity;
        private System.Windows.Forms.ComboBox cmb_stop_bits;
        private System.Windows.Forms.Label lbl_stop_bits;
        private System.Windows.Forms.ComboBox cmb_flow_control;
        private System.Windows.Forms.Label lbl_flow_control;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox grp_port;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd_file_explorer;
        private System.Windows.Forms.TextBox txt_file_name;
        private System.Windows.Forms.GroupBox grp_file;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ListView lvwFileData;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.TextBox txt_base_address;
        private System.Windows.Forms.GroupBox grp_file_content;
        private System.Windows.Forms.Label lbl_base_address;
        private System.Windows.Forms.Label lbl_file_size;
        private System.Windows.Forms.TextBox txt_file_size;
        private System.Windows.Forms.GroupBox grp_device;
        private System.Windows.Forms.Label lbl_device_id;
        private System.Windows.Forms.TextBox txt_device_id;
        private System.Windows.Forms.Label lbl_bl_version;
        private System.Windows.Forms.TextBox txt_bl_version;
        private System.Windows.Forms.Button btn_device_connect;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Timer tim_Connect;
    }
}

