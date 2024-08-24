namespace TallerEventos
{
    partial class Form1
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
            txtNombreTarea = new TextBox();
            btnAgregarTarea = new Button();
            flowPanelTareasPendientes = new FlowLayoutPanel();
            flowPanelTareasEnProgreso = new FlowLayoutPanel();
            flowPanelTareasCompletadas = new FlowLayoutPanel();
            cmbEstado = new ComboBox();
            SuspendLayout();
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(84, 73);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(158, 27);
            txtNombreTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(464, 72);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(94, 29);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "Agregar";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // flowPanelTareasPendientes
            // 
            flowPanelTareasPendientes.FlowDirection = FlowDirection.TopDown;
            flowPanelTareasPendientes.Location = new Point(84, 139);
            flowPanelTareasPendientes.Name = "flowPanelTareasPendientes";
            flowPanelTareasPendientes.Size = new Size(146, 269);
            flowPanelTareasPendientes.TabIndex = 2;
            // 
            // flowPanelTareasEnProgreso
            // 
            flowPanelTareasEnProgreso.FlowDirection = FlowDirection.TopDown;
            flowPanelTareasEnProgreso.Location = new Point(247, 139);
            flowPanelTareasEnProgreso.Name = "flowPanelTareasEnProgreso";
            flowPanelTareasEnProgreso.Size = new Size(146, 269);
            flowPanelTareasEnProgreso.TabIndex = 4;
            // 
            // flowPanelTareasCompletadas
            // 
            flowPanelTareasCompletadas.FlowDirection = FlowDirection.TopDown;
            flowPanelTareasCompletadas.Location = new Point(412, 139);
            flowPanelTareasCompletadas.Name = "flowPanelTareasCompletadas";
            flowPanelTareasCompletadas.Size = new Size(146, 269);
            flowPanelTareasCompletadas.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(268, 72);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbEstado);
            Controls.Add(flowPanelTareasCompletadas);
            Controls.Add(flowPanelTareasEnProgreso);
            Controls.Add(flowPanelTareasPendientes);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtNombreTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreTarea;
        private Button btnAgregarTarea;
        private FlowLayoutPanel flowPanelTareasPendientes;
        private FlowLayoutPanel flowPanelTareasEnProgreso;
        private FlowLayoutPanel flowPanelTareasCompletadas;
        private ComboBox cmbEstado;
    }
}
