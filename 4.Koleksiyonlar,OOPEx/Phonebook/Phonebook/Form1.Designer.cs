namespace Phonebook
{
    partial class Form1  // bu kısmı vs kendisi otomatik kodlar yazarak yönetiyor. gerekirse bizde müdahale edebiliyoruz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()// senin formun içerisinde bulunan bütün nesneleri tanımlıyor.özelliklrine değerler atıyor.
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        
        #endregion
       
        
    }
}
/*hem form1.designer.cs de hemde form1.cs den form1 var. aynı namespace altında birden fazla aynı isimli 2 tane sınıf olamaz. bu partial
 sınıf olarak geliştirilmiş. parçalı sınıflar olarak geliştirmemizi sağlayan yapı. bazen sınıflarımızn içerisinde çok fazla kod old için sınıfı 
 iki farklı dosya içerisinde yönetmek isteyebiliriz. */
