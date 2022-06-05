using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impuestos_sobre_la_renta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Salario Bruto
        private static double SB = 0;
        static void Main(string[] args)
        {
            // Las variables
            int a;
            string vNombre;

            a = 0;

            Console.WriteLine("Introduzca la cantidad de salarios a calcular\n" +
                "1 - 2- 3 - 4");
            a = Convert.ToInt32(Console.ReadLine());
            int[] vSB = new int[a];
            string[] vAN = new string[a];

            // bucle
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Ingrese el nombre: ");
                vNombre = Console.ReadLine();
                vAN[i] = vNombre;

                Console.Write("Inserte su sueldo bruto(SB): ");
                SB = double.Parse(Console.ReadLine());
                vSB[i] = Convert.ToInt32(SB);

                Console.WriteLine("\n");
            }

            // --------------------------------------------------------------------------------------Mostrar los datos en pantalla-------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Nombre: " + vAN[i] + "||" + "El Sueldo Bruto es:" + vSB[i]);
            }

            Console.WriteLine("\n");

            Console.WriteLine("La nomina es: \n");
            int vR = 0;

            while (vR < a)
            {
                Console.WriteLine("Nombre: " + vAN[vR] + " |" + "El Sueldo Bruto es:" + vSB[vR]
                + "  ISR: " + ISR() + "  AFP: " + AFP() + "  SFS: " + SFS() + "   Sueldo Neto: " + SN());
                Console.WriteLine("\n");
                Console.Write("Las deducciones son: " + vD());
                Console.WriteLine("\n");
                vR++;
            }

            Console.ReadKey();


            // ----------------------------------------------------------------------------------------------Los Metodos-------------------------------------------------------------------------------------------------------------------------------------
            static double ISR()
            {
                double vISR = 0;
                if (SB < 25000)
                {
                    vISR = SB;
                }
                if (SB >= 25000)
                {
                    vISR = SB * 0.2;
                }
                if (SB >= 55000)
                {
                    vISR = SB * 0.25;
                }
                if (SB >= 85000)
                {
                    vISR = SB * 0.3;
                }
                return vISR;

            }
            static double AFP()
            {
                double vAFP = SB * 0.0287;
                return vAFP;
            }
            static double SFS()
            {
                double vSFS = SB * 0.0304;
                return vSFS;
            }
            static double vD()
            {
                double vD = ISR() - AFP() - SFS();
                return vD;
            }
            static double SN()
            {
                double vSN = SB - vD();
                return vSN;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }