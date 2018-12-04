using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices
{
    /// <summary>
    /// Hecho por : Ing. Nelly Henríquez
    /// Programa que permite encontrar el producto de dos matrices cuadradas que están previamente inicializadas y muestra la matriz resultante
    /// Como ejercicio adicional puedes leer los datos de la matriz desde el formulario.
    /// </summary>
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// encuentra el producto de dos matrices
        /// </summary>
        /// <param name="matA"></param>
        /// <param name="matB"></param>
        /// <returns></returns>
        private string Producto(int [,]matA,int [,]matB )
        {
            //Encontrando el producto de dos matrices.
            String mat = "";
            int[,] matrizC = new int[matA.GetLength(0), matB.GetLength(1)];
            for (int i = 0; i < matA.GetLength(0); i++)
            {
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    for (int k = 0; k < matB.GetLength(1); k++)
                    {
                        matrizC[i, j] += matA[i, k] * matB[k, j];
                            }
                }
            }
            mat=ImprimirMatriz(matrizC);
            return mat;
        }
        /// <summary>
        /// método que permite imprimir una Matriz en una variable tipo string, luego se presentaran en un textbox
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        private static string ImprimirMatriz(int[,] mat)
        {
            string matriz = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    matriz+= Convert.ToString(mat[i, j])+"\t";
                }
                matriz += Environment.NewLine;
            }
            return matriz;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //Si se quiere hacer con matrices previamente inicializado sería de la 
            //siguiente manera:
            int[,] matrizA = new int[,] { { 2,0,1},
                                           { 3,0,0},
                                           { 5,1,1 } };

             int[,] matrizB = new int[,] { { 1,0,1},
                                           { 1,2,1},
                                           { 1,1,0} };
            string stMatA, stMatB;


            /* Puedes probar también con los siguientes valores 
             
               int[,] matrizA = new int[,] { { 2,0,1,1},
                                             { 3,0,0,1},
                                             { 5,1,1,1},
                                             { 5,1,1,1}};

            int[,] matrizB = new int[,] { { 1,0,1,1},
                                          { 1,2,1,1},
                                          { 1,1,0,1},
                                          { 1,1,0,1}};*/


            txtMatriz.Text = Producto(matrizA, matrizB);
            stMatA = ImprimirMatriz(matrizA);
            stMatB = ImprimirMatriz(matrizB);
            txtMat1.Text = stMatA;
            txtMat2.Text = stMatB;

        }
        }
    }

