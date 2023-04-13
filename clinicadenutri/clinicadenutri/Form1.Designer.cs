namespace clinicadenutri
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sobrenomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dtNascimentoLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label alturaLabel;
            System.Windows.Forms.Label iMCLabel;
            System.Windows.Forms.Label condicaoLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label oBSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pACIENTESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pACIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLINICANUTRIDataSet = new clinicadenutri.CLINICANUTRIDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pACIENTESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.dtNascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.iMCTextBox = new System.Windows.Forms.TextBox();
            this.condicaoTextBox = new System.Windows.Forms.TextBox();
            this.oBSTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pACIENTESTableAdapter = new clinicadenutri.CLINICANUTRIDataSetTableAdapters.PACIENTESTableAdapter();
            this.tableAdapterManager = new clinicadenutri.CLINICANUTRIDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            codigoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            sobrenomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            dtNascimentoLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            alturaLabel = new System.Windows.Forms.Label();
            iMCLabel = new System.Windows.Forms.Label();
            condicaoLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            oBSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTESBindingNavigator)).BeginInit();
            this.pACIENTESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICANUTRIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(254, 39);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Código:";
            codigoLabel.Click += new System.EventHandler(this.codigoLabel_Click);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(254, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(45, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome: *";
            // 
            // sobrenomeLabel
            // 
            sobrenomeLabel.AutoSize = true;
            sobrenomeLabel.Location = new System.Drawing.Point(254, 91);
            sobrenomeLabel.Name = "sobrenomeLabel";
            sobrenomeLabel.Size = new System.Drawing.Size(64, 13);
            sobrenomeLabel.TabIndex = 5;
            sobrenomeLabel.Text = "Sobrenome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(254, 117);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(254, 163);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 9;
            celularLabel.Text = "Celular:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(254, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(254, 215);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(41, 13);
            sexoLabel.TabIndex = 13;
            sexoLabel.Text = "Sexo: *";
            // 
            // dtNascimentoLabel
            // 
            dtNascimentoLabel.AutoSize = true;
            dtNascimentoLabel.Location = new System.Drawing.Point(254, 242);
            dtNascimentoLabel.Name = "dtNascimentoLabel";
            dtNascimentoLabel.Size = new System.Drawing.Size(80, 13);
            dtNascimentoLabel.TabIndex = 15;
            dtNascimentoLabel.Text = "Dt Nascimento:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(254, 268);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(41, 13);
            pesoLabel.TabIndex = 17;
            pesoLabel.Text = "Peso: *";
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.Location = new System.Drawing.Point(254, 294);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new System.Drawing.Size(44, 13);
            alturaLabel.TabIndex = 19;
            alturaLabel.Text = "Altura: *";
            // 
            // iMCLabel
            // 
            iMCLabel.AutoSize = true;
            iMCLabel.Location = new System.Drawing.Point(254, 320);
            iMCLabel.Name = "iMCLabel";
            iMCLabel.Size = new System.Drawing.Size(36, 13);
            iMCLabel.TabIndex = 21;
            iMCLabel.Text = "IMC: *";
            // 
            // condicaoLabel
            // 
            condicaoLabel.AutoSize = true;
            condicaoLabel.Location = new System.Drawing.Point(254, 346);
            condicaoLabel.Name = "condicaoLabel";
            condicaoLabel.Size = new System.Drawing.Size(62, 13);
            condicaoLabel.TabIndex = 23;
            condicaoLabel.Text = "Condição: *";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(580, 25);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 25;
            fotoLabel.Text = "Foto:";
            // 
            // oBSLabel
            // 
            oBSLabel.AutoSize = true;
            oBSLabel.Location = new System.Drawing.Point(267, 371);
            oBSLabel.Name = "oBSLabel";
            oBSLabel.Size = new System.Drawing.Size(32, 13);
            oBSLabel.TabIndex = 27;
            oBSLabel.Text = "OBS:";
            // 
            // pACIENTESBindingNavigator
            // 
            this.pACIENTESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pACIENTESBindingNavigator.BindingSource = this.pACIENTESBindingSource;
            this.pACIENTESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pACIENTESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pACIENTESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pACIENTESBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.pACIENTESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pACIENTESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pACIENTESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pACIENTESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pACIENTESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pACIENTESBindingNavigator.Name = "pACIENTESBindingNavigator";
            this.pACIENTESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pACIENTESBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.pACIENTESBindingNavigator.TabIndex = 0;
            this.pACIENTESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // pACIENTESBindingSource
            // 
            this.pACIENTESBindingSource.DataMember = "PACIENTES";
            this.pACIENTESBindingSource.DataSource = this.cLINICANUTRIDataSet;
            // 
            // cLINICANUTRIDataSet
            // 
            this.cLINICANUTRIDataSet.DataSetName = "CLINICANUTRIDataSet";
            this.cLINICANUTRIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pACIENTESBindingNavigatorSaveItem
            // 
            this.pACIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pACIENTESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pACIENTESBindingNavigatorSaveItem.Image")));
            this.pACIENTESBindingNavigatorSaveItem.Name = "pACIENTESBindingNavigatorSaveItem";
            this.pACIENTESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pACIENTESBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pACIENTESBindingNavigatorSaveItem.Click += new System.EventHandler(this.pACIENTESBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::clinicadenutri.Properties.Resources._876054;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(340, 36);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(121, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(340, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Sobrenome", true));
            this.sobrenomeTextBox.Location = new System.Drawing.Point(340, 88);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.sobrenomeTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(340, 114);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(121, 40);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(340, 160);
            this.celularMaskedTextBox.Mask = "(00) 00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.celularMaskedTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(340, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Sexo", true));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.sexoComboBox.Location = new System.Drawing.Point(340, 212);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexoComboBox.TabIndex = 14;
            // 
            // dtNascimentoMaskedTextBox
            // 
            this.dtNascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "DtNascimento", true));
            this.dtNascimentoMaskedTextBox.Location = new System.Drawing.Point(340, 239);
            this.dtNascimentoMaskedTextBox.Mask = "00/00/0000";
            this.dtNascimentoMaskedTextBox.Name = "dtNascimentoMaskedTextBox";
            this.dtNascimentoMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.dtNascimentoMaskedTextBox.TabIndex = 16;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(340, 265);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(121, 20);
            this.pesoTextBox.TabIndex = 18;
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Altura", true));
            this.alturaTextBox.Location = new System.Drawing.Point(340, 291);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(121, 20);
            this.alturaTextBox.TabIndex = 20;
            // 
            // iMCTextBox
            // 
            this.iMCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "IMC", true));
            this.iMCTextBox.Location = new System.Drawing.Point(340, 317);
            this.iMCTextBox.Name = "iMCTextBox";
            this.iMCTextBox.Size = new System.Drawing.Size(121, 20);
            this.iMCTextBox.TabIndex = 22;
            this.iMCTextBox.TextChanged += new System.EventHandler(this.iMCTextBox_TextChanged);
            // 
            // condicaoTextBox
            // 
            this.condicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "Condicao", true));
            this.condicaoTextBox.Location = new System.Drawing.Point(340, 343);
            this.condicaoTextBox.Name = "condicaoTextBox";
            this.condicaoTextBox.Size = new System.Drawing.Size(121, 20);
            this.condicaoTextBox.TabIndex = 24;
            this.condicaoTextBox.TextChanged += new System.EventHandler(this.condicaoTextBox_TextChanged);
            // 
            // oBSTextBox
            // 
            this.oBSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTESBindingSource, "OBS", true));
            this.oBSTextBox.Location = new System.Drawing.Point(340, 368);
            this.oBSTextBox.Multiline = true;
            this.oBSTextBox.Name = "oBSTextBox";
            this.oBSTextBox.Size = new System.Drawing.Size(121, 47);
            this.oBSTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = " * Campos Obrigatórios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 20);
            this.button1.TabIndex = 31;
            this.button1.Text = "Inserir Foto ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::clinicadenutri.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(45, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pACIENTESTableAdapter
            // 
            this.pACIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONSULTAPACIENTETableAdapter = null;
            this.tableAdapterManager.PACIENTESTableAdapter = this.pACIENTESTableAdapter;
            this.tableAdapterManager.UpdateOrder = clinicadenutri.CLINICANUTRIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(551, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinicadenutri.Properties.Resources.logo_final_youtility_em_preto__Copia_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(sobrenomeLabel);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(dtNascimentoLabel);
            this.Controls.Add(this.dtNascimentoMaskedTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(alturaLabel);
            this.Controls.Add(this.alturaTextBox);
            this.Controls.Add(iMCLabel);
            this.Controls.Add(this.iMCTextBox);
            this.Controls.Add(condicaoLabel);
            this.Controls.Add(this.condicaoTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(oBSLabel);
            this.Controls.Add(this.oBSTextBox);
            this.Controls.Add(this.pACIENTESBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Clinica nutri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTESBindingNavigator)).EndInit();
            this.pACIENTESBindingNavigator.ResumeLayout(false);
            this.pACIENTESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICANUTRIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CLINICANUTRIDataSet cLINICANUTRIDataSet;
        private System.Windows.Forms.BindingSource pACIENTESBindingSource;
        private CLINICANUTRIDataSetTableAdapters.PACIENTESTableAdapter pACIENTESTableAdapter;
        private CLINICANUTRIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pACIENTESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pACIENTESBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.MaskedTextBox dtNascimentoMaskedTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.TextBox iMCTextBox;
        private System.Windows.Forms.TextBox condicaoTextBox;
        private System.Windows.Forms.TextBox oBSTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

