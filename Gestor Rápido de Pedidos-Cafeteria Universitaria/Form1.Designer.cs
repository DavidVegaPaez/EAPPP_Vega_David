namespace Gestor_Rápido_de_Pedidos_Cafetería_Universitaria
{
    partial class frmPedidoCafeteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Empanada de queso", "$1.25" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Sánduche de Pollo", "$2.50" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Bolón de verde mixto", "$2.25" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Humita tradicional", "$1.50" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "Tostada con queso", "$1.00" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "Café pasado", "$0.85" }, -1);
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "Chocolate caliente", "$1.35" }, -1);
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "Jugo natural (naranja/mora)", "$1.50" }, -1);
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "Batido de fruta", "$2.00" }, -1);
            ListViewItem listViewItem20 = new ListViewItem(new string[] { "Botella de agua", "$0.75" }, -1);
            lvCatalogo = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            rbtnMostrador = new RadioButton();
            rbtnEntrega = new RadioButton();
            chkPostre = new CheckBox();
            chkServilletas = new CheckBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            lvPedido = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblCliente = new Label();
            lblProducto = new Label();
            label1 = new Label();
            grbAtencion = new GroupBox();
            grbAtencion.SuspendLayout();
            SuspendLayout();
            // 
            // lvCatalogo
            // 
            lvCatalogo.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            lvCatalogo.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20 });
            lvCatalogo.Location = new Point(13, 150);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(238, 229);
            lvCatalogo.TabIndex = 0;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.View = View.Details;
            lvCatalogo.SelectedIndexChanged += lvCatalogo_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Producto";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Precio";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(87, 59);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 2;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(266, 59);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(446, 59);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 4;
            txtCantidad.Text = "1";
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Checked = true;
            rbtnMostrador.Location = new Point(10, 22);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(130, 19);
            rbtnMostrador.TabIndex = 5;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Retiro en mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(10, 49);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(164, 19);
            rbtnEntrega.TabIndex = 6;
            rbtnEntrega.Text = "Entrega en el aula (+$0,50)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(336, 239);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(143, 19);
            chkPostre.TabIndex = 7;
            chkPostre.Text = "Postre del día (+$1,00)";
            chkPostre.UseVisualStyleBackColor = true;
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(336, 264);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(140, 19);
            chkServilletas.TabIndex = 8;
            chkServilletas.Text = "Servilletas / Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(353, 305);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 25);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar Ítem";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.AutoSize = true;
            btnQuitar.Location = new Point(353, 336);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(123, 25);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "Quitar Seleccionado";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = true;
            btnLimpiar.Location = new Point(353, 367);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 25);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(13, 426);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(173, 15);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado: Seleccione un producto";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(654, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(134, 32);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: $0,00";
            // 
            // lvPedido
            // 
            lvPedido.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvPedido.FullRowSelect = true;
            lvPedido.Location = new Point(588, 150);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(200, 229);
            lvPedido.TabIndex = 14;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Subtotal";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(34, 62);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 15;
            lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(201, 62);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 16;
            lblProducto.Text = "Producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, -3);
            label1.Name = "label1";
            label1.Size = new Size(545, 32);
            label1.TabIndex = 17;
            label1.Text = "Gestor Rápido de Pedidos - Cafetería Universitaria\r\n";
            // 
            // grbAtencion
            // 
            grbAtencion.Controls.Add(rbtnEntrega);
            grbAtencion.Controls.Add(rbtnMostrador);
            grbAtencion.Location = new Point(326, 133);
            grbAtencion.Name = "grbAtencion";
            grbAtencion.Size = new Size(200, 78);
            grbAtencion.TabIndex = 18;
            grbAtencion.TabStop = false;
            grbAtencion.Text = "Modalidad de Atención";
            // 
            // frmPedidoCafeteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbAtencion);
            Controls.Add(label1);
            Controls.Add(lblProducto);
            Controls.Add(lblCliente);
            Controls.Add(lvPedido);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(chkServilletas);
            Controls.Add(chkPostre);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(lvCatalogo);
            Name = "frmPedidoCafeteria";
            Text = "Gestor Rápido de Pedidos con Catálogo - Cafetería Universitaria";
            grbAtencion.ResumeLayout(false);
            grbAtencion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvCatalogo;
        private ListBox listBox1;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private RadioButton rbtnMostrador;
        private RadioButton rbtnEntrega;
        private CheckBox chkPostre;
        private CheckBox chkServilletas;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
        private ListView lvPedido;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblCliente;
        private Label lblProducto;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private GroupBox grbAtencion;
    }
}
