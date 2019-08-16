﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Id = 1;
            heroe1.Nombre = "Hulk";
            heroe1.NivelDePoder = 100;
            heroe1.Genero = "Masculino";
            heroe1.SuperFuerza = true;
            heroe1.Velocidad = true;
            heroe1.Volar = false;
            heroe1.Telequinesis = false;
            heroe1.NiveldeFama = 100;
            var heroe2 = new Heroe();
            heroe2.Id = 2;
            heroe2.Nombre = "Profesor X";
            heroe2.NivelDePoder = 90;
            heroe2.Genero = "Masculino";
            heroe2.Telequinesis = true;
            heroe2.SuperFuerza = false;
            heroe2.Velocidad = false;
            heroe2.Volar = true;
            heroe2.NiveldeFama = 60;
            var heroe3 = new Heroe();
            heroe3.Id = 3;
            heroe3.Nombre = "Flash";
            heroe3.NivelDePoder = 100;
            heroe3.Genero = "Masculino";
            heroe3.Velocidad = true;
            heroe3.Telequinesis = false;
            heroe3.SuperFuerza = true;
            heroe3.Volar = false;
            heroe3.NiveldeFama = 75;
            MessageBox.Show("\nNombre:" + heroe1.Nombre + "\nNivel De Poder:" + heroe1.NivelDePoder + "\nGenero:" + heroe1.Genero + "\nSuper Fuerza:" + heroe1.SuperFuerza + "\nVuela:" + heroe1.Volar + "\nTelequinesis:" + heroe1.Telequinesis + "\nVelocidad:" + heroe1.Velocidad+"\nFama:" +heroe1.NiveldeFama);
            MessageBox.Show("\nNombre:" + heroe2.Nombre + "\nNivel De Poder:" + heroe2.NivelDePoder + "\nGenero:" + heroe2.Genero + "\nSuper Fuerza:" + heroe2.SuperFuerza + "\nVuela:" + heroe2.Volar + "\nTelequinesis:" + heroe2.Telequinesis + "\nVelocidad:" + heroe2.Velocidad + "\nFama:" + heroe2.NiveldeFama);
            MessageBox.Show("\nNombre:" + heroe3.Nombre + "\nNivel De Poder:" + heroe3.NivelDePoder + "\nGenero:" + heroe3.Genero + "\nSuper Fuerza:" + heroe3.SuperFuerza + "\nVuela:" + heroe3.Volar + "\nTelequinesis:" + heroe3.Telequinesis + "\nVelocidad:" + heroe3.Velocidad + "\nFama:" + heroe3.NiveldeFama);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var villano1 = new Villano();
            villano1.Id = 1;
            villano1.Nombre = "Thanos";
            villano1.NivelDePoder = 100;
            villano1.Genero = "Masculino";
            villano1.SuperFuerza = true;
            villano1.Telequinesis = true;
            villano1.Volar = false;
            villano1.Velocidad = false;
            villano1.NiveldeMaldad = 100;

            var villano2 = new Villano();
            villano2.Id = 1;
            villano2.Nombre = "Savitar";
            villano2.NivelDePoder = 70;
            villano2.Genero = "Masculino";
            villano2.SuperFuerza = true;
            villano2.Telequinesis = false;
            villano2.Volar = false;
            villano2.Velocidad = true;
            villano2.NiveldeMaldad = 85;

            var villano3 = new Villano();
            villano3.Id = 1;
            villano3.Nombre = "Beyonder";
            villano3.NivelDePoder = 100;
            villano3.Genero = "Masculino";
            villano3.SuperFuerza = true;
            villano3.Telequinesis = true;
            villano3.Volar = true;
            villano3.Velocidad = true;
            villano3.NiveldeMaldad = 50;
            MessageBox.Show("\nNombre:" + villano1.Nombre + "\nNivel De Poder:" + villano1.NivelDePoder + "\nGenero:" + villano1.Genero + "\nSuper Fuerza:" + villano1.SuperFuerza + "\nVuela:" + villano1.Volar + "\nTelequinesis:" + villano1.Telequinesis + "\nVelocidad:" + villano1.Velocidad + "\nMaldas:" + villano1.NiveldeMaldad);
            MessageBox.Show("\nNombre:" + villano2.Nombre + "\nNivel De Poder:" + villano2.NivelDePoder + "\nGenero:" + villano2.Genero + "\nSuper Fuerza:" + villano2.SuperFuerza + "\nVuela:" + villano2.Volar + "\nTelequinesis:" + villano2.Telequinesis + "\nVelocidad:" + villano2.Velocidad + "\nMaldas:" + villano2.NiveldeMaldad);
            MessageBox.Show("\nNombre:" + villano3.Nombre + "\nNivel De Poder:" + villano3.NivelDePoder + "\nGenero:" + villano3.Genero + "\nSuper Fuerza:" + villano3.SuperFuerza + "\nVuela:" + villano3.Volar + "\nTelequinesis:" + villano3.Telequinesis + "\nVelocidad:" + villano3.Velocidad + "\nMaldas:" + villano3.NiveldeMaldad);
        }
    }
}
