namespace Introduccion
{
    public partial class Form1 : Form
    {
        private Label? lblFigura;
        private ComboBox? cmbFiguras;
        private Label? lblCalculo;
        private ComboBox? cmbCalculos;
        private Label? lblAlto;
        private Label? lbAncho;
        private TextBox txtAncho;
        private TextBox? txtAlto;
        private Label? lblResultado;
        private TextBox? txtResultado;
        private Button? btnCalcular;
        private Label? lbBase;
        private TextBox txtBase;
        private Label? lbLado2;
        private TextBox txtLado2;
        private Label? lbLado3;
        private TextBox txtLado3;
        private Label? lbAltura;
        private TextBox txtAltura;
        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();

        }
        private void InicializarComponentes()
        {
            // Tama�o de la ventana
            this.Size = new Size(300, 350);

            //Etiqueta Figura
            lblFigura = new Label();
            lblFigura.Text = "Figura";
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(10, 10);

            //ComboBox Figuras
            cmbFiguras = new ComboBox();
            cmbFiguras.Items.Add("Selecciona figura");
            cmbFiguras.Items.Add("Cuadrado");
            cmbFiguras.Items.Add("Triangulo");
            cmbFiguras.Items.Add("Rectangulo");
            cmbFiguras.SelectedIndex = 0;
            cmbFiguras.Location = new Point(10, 40);
            cmbFiguras.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

            //Etiqueta Calculo
            lblCalculo = new Label();
            lblCalculo.Text = "C�lculo";
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(150, 10);

            //ComboBox Calculos
            cmbCalculos = new ComboBox();
            cmbCalculos.Items.Add("Selecciona calculo");
            cmbCalculos.Items.Add("P�rimetro");
            cmbCalculos.Items.Add("�rea");
            cmbCalculos.SelectedIndex = 0;
            cmbCalculos.Location = new Point(150, 40);
            cmbCalculos.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

            //Etiqueta Altura
            lblAlto = new Label();
            lblAlto.Text = "Alto";
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(10, 100);
            lblAlto.Visible = false;

            //TextBox Altura
            txtAlto = new TextBox();
            txtAlto.Size = new Size(100, 20);
            txtAlto.Location = new Point(60, 105);
            txtAlto.Visible = false;

            //Etiqueta Ancho
            lbAncho = new Label();
            lbAncho.Text = "Ancho";
            lbAncho.AutoSize = true;
            lbAncho.Location = new Point(10, 75);
            lbAncho.Visible = false;

            //TextBox Ancho
            txtAncho = new TextBox();
            txtAncho.Size = new Size(100, 20);
            txtAncho.Location = new Point(60, 80);
            txtAncho.Visible = false;
            
            //Etiqueta Base
            lbBase = new Label();
            lbBase.Text = "Base";
            lbBase.AutoSize = true;
            lbBase.Location = new Point(10, 75);
            lbBase.Visible = false;

            //TextBox Base
            txtBase = new TextBox();
            txtBase.Size = new Size(100, 20);
            txtBase.Location = new Point(60, 80);
            txtBase.Visible = false;
            
            //Etiqueta Altura
            lbAltura = new Label();
            lbAltura.Text = "Altura";
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(10, 120);
            lbAltura.Visible = false;

            //TextBox Base
            txtAltura = new TextBox();
            txtAltura.Size = new Size(100, 20);
            txtAltura.Location = new Point(60, 125);
            txtAltura.Visible = false;

            //Etiqueta Lado3
            lbLado3 = new Label();
            lbLado3.Text = "Lado 3";
            lbLado3.AutoSize = true;
            lbLado3.Location = new Point(10, 120);
            lbLado3.Visible = false;

            //TextBox Lado3
            txtLado3 = new TextBox();
            txtLado3.Size = new Size(100, 20);
            txtLado3.Location = new Point(60, 125);
            txtLado3.Visible = false;
            
            //Etiqueta Lado2
            lbLado2 = new Label();
            lbLado2.Text = "Lado 2";
            lbLado2.AutoSize = true;
            lbLado2.Location = new Point(10, 100);
            lbLado2.Visible = false;

            //TextBox Lado2
            txtLado2 = new TextBox();
            txtLado2.Size = new Size(100, 20);
            txtLado2.Location = new Point(60, 105);
            txtLado2.Visible = false;

            //Etiqueta resultado
            lblResultado = new Label();
            lblResultado.Text = "Resultado";
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(10, 280);

            //TextBox resultado
            txtResultado = new TextBox();
            txtResultado.Size = new Size(100, 20);
            txtResultado.Location = new Point(70, 275);
            
            //Etiqueta resultado
            lblResultado = new Label();
            lblResultado.Text = "Resultado";
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(10, 280);

            //TextBox Prueba
            txtResultado = new TextBox();
            txtResultado.Size = new Size(100, 20);
            txtResultado.Location = new Point(70, 275);

            //Boton Calcular
            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.AutoSize = true;
            btnCalcular.Location = new Point(200, 200);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);

            //Agregar controles a la ventana
            this.Controls.Add(lblFigura);
            this.Controls.Add(cmbFiguras);
            this.Controls.Add(lblCalculo);
            this.Controls.Add(cmbCalculos);
            this.Controls.Add(lblAlto);
            this.Controls.Add(txtAlto);
            this.Controls.Add(lbAncho);
            this.Controls.Add(txtAncho);
            this.Controls.Add(lbBase);
            this.Controls.Add(txtBase);
            this.Controls.Add(lbAltura);
            this.Controls.Add(txtAltura);
            this.Controls.Add(lbLado2);
            this.Controls.Add(txtLado2);
            this.Controls.Add(lbLado3);
            this.Controls.Add(txtLado3);
            this.Controls.Add(lblResultado);
            this.Controls.Add(txtResultado);
            this.Controls.Add(btnCalcular);

        }
        private void cmb_ValueChanged(object sender, EventArgs e)
        {
            if (cmbCalculos.SelectedIndex != 0 && cmbFiguras.SelectedIndex != 0)
            {
                if (cmbFiguras.SelectedItem.ToString() == "Cuadrado")
                {
                    quitarContenido();
                    quitarTxtYBox();
                    //cmbFigura.SelectedIndex==1
                    if (cmbCalculos.SelectedItem.ToString() == "P�rimetro")
                    {
                        txtAlto.Visible = true;
                        lblAlto.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "�rea")
                    {
                        txtAlto.Visible = true;
                        lblAlto.Visible = true;
                    }

                }else if (cmbFiguras.SelectedItem.ToString() == "Rectangulo")
                {
                    quitarContenido();
                    quitarTxtYBox();
                    if (cmbCalculos.SelectedItem.ToString() == "P�rimetro")
                    {
                        txtAlto.Visible = true;
                        lblAlto.Visible = true;
                        lbAncho.Visible = true;
                        txtAncho.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "�rea")
                    {
                        txtAlto.Visible = true;
                        lblAlto.Visible = true;
                        lbAncho.Visible = true;
                        txtAncho.Visible = true;
                    }
                }
                else if (cmbFiguras.SelectedItem.ToString() == "Triangulo")
                {
                    quitarContenido();
                    quitarTxtYBox();
                    if (cmbCalculos.SelectedItem.ToString() == "P�rimetro")
                    {
                        lbBase.Visible = true;
                        txtBase.Visible = true;
                        lbLado2.Visible = true;
                        txtLado2.Visible = true;
                        lbLado3.Visible = true;
                        txtLado3.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "�rea")
                    {
                        txtAltura.Visible = true;
                        lbAltura.Visible = true;
                        lbBase.Visible = true;
                        txtBase.Visible = true;
                    }
                }
            }
            else
            {
                quitarContenido();
                quitarTxtYBox();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string calculo = cmbCalculos.SelectedItem.ToString();
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado")
            { 
                //cmbFigura.SelectedIndex==1
                if (calculo == "P�rimetro")
                {
                    double alto = 0.0;
                    if (double.TryParse(txtAlto.Text, out alto) && alto > 0.0) 
                    { 
                        txtResultado.Text = (alto * 4).ToString();
                    }
                } 
                if (calculo == "�rea") 
                { 
                    double alto = 0; 
                    if (double.TryParse(txtAlto.Text, out alto) && alto > 0) 
                    { 
                        txtResultado.Text = (alto * alto).ToString();
                    }
                }

            }else if (cmbFiguras.SelectedItem.ToString() == "Rectangulo")
            {
                if (calculo == "P�rimetro")
                {
                    double alto = 0;
                    double ancho = 0;
                    if ((double.TryParse(txtAlto.Text, out alto) && alto > 0) && (double.TryParse(txtAncho.Text, out ancho) && ancho > 0))
                    {
                        txtResultado.Text = alto*2 + ancho*2  + "";
                    }
                }
                if (calculo == "�rea")
                {
                    double alto = 0;
                    double ancho = 0;
                    if ((double.TryParse(txtAlto.Text, out alto) && alto > 0) && (double.TryParse(txtAncho.Text, out ancho) && ancho > 0))
                    {
                        txtResultado.Text = alto*ancho  + "";
                    }
                }
            }
            else if (cmbFiguras.SelectedItem.ToString() == "Triangulo")
            {
                if (calculo == "P�rimetro")
                {
                    double base1 = 0;
                    double lado2 = 0;
                    double lado3 = 0;
                    if ((double.TryParse(txtBase.Text, out base1) && base1 > 0) && (double.TryParse(txtLado2.Text, out lado2) && lado2 > 0)
                        && (double.TryParse(txtLado3.Text, out lado3) && lado3 > 0))
                    {
                        lblResultado.Text = "sdasdas";
                        txtResultado.Text = (base1+lado2+lado3).ToString();
                    }
                }
                if (calculo == "�rea")
                {
                    double altura = 0;
                    double base1 = 0;
                    if ((double.TryParse(txtAltura.Text, out altura) && altura > 0) && (double.TryParse(txtBase.Text, out base1) && base1 > 0))
                    {
                        txtResultado.Text = (base1*altura/2).ToString(); 
                            
                    } 
                }
            }
        }

        private void quitarTxtYBox()
        {
            txtAltura.Visible = false;
            lbAltura.Visible = false;
            lbBase.Visible = false;
            txtBase.Visible = false;
            lbLado2.Visible = false;
            txtLado2.Visible = false;
            lbLado3.Visible = false;
            txtLado3.Visible = false;
            txtAlto.Visible = false;
            lblAlto.Visible = false;
            lbAncho.Visible = false;
            txtAncho.Visible = false;
            txtAlto.Visible = false;
            lblAlto.Visible = false;
        }
        
        private void quitarContenido()
        {
            txtAltura.Text = "";
            txtBase.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            txtAlto.Text = "";
            txtAncho.Text = "";
            txtAlto.Text = "";
        }

    }
}