using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;

namespace EjemploJsonXamarin
{
    [Activity(Label = "Libros Json", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected Button bGenerarJson, bMostrarJson, bGenerarLista, bLevantarLista;
        protected EditText eAutor, eLibro, eInfo;
        protected Libro libro;
        protected List<Libro> listaLibros;
        protected string pathListaLibro, pathLibro;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
        }

        protected void SetComponents()
        {
            bGenerarJson = FindViewById<Button>(Resource.Id.bGenerarJson);
            bGenerarLista = FindViewById<Button>(Resource.Id.bGenerarListaJson);
            bMostrarJson = FindViewById<Button>(Resource.Id.bMostrarJson);
            bLevantarLista = FindViewById<Button>(Resource.Id.bLevantarListaJson);
            eAutor = FindViewById<EditText>(Resource.Id.eAutor);
            eLibro = FindViewById<EditText>(Resource.Id.eLibro);
            eInfo = FindViewById<EditText>(Resource.Id.eInfo);

            libro = new Libro();
            listaLibros = new List<Libro>();
            pathLibro = Android.OS.Environment.ExternalStorageDirectory + "/Documents/Libro.json";
            pathListaLibro = Android.OS.Environment.ExternalStorageDirectory + "/Documents/ListaLibros.json";
        }

        protected void Delegar()
        {
            bGenerarJson.Click += delegate { GenerarJson(); };
            bGenerarLista.Click += delegate { GenerarListaJson(); };
            bMostrarJson.Click += delegate { MostrarJson(); };
            bLevantarLista.Click += delegate { LevantarListaJson(); };
        }

        //Este método genera un objeto Json y lo guarda en la carpeta documentos de nuestro celular.
        protected void GenerarJson()
        {
            try
            {
                if (eAutor.Text == string.Empty && eLibro.Text == string.Empty)
                {
                    eAutor.Error = "Debe ingresar un valor";
                    eLibro.Error = "Debe ingresar un valor";
                }
                else
                {
                    libro.autor = eAutor.Text;
                    libro.nombre = eLibro.Text;
                    var stringJson = JsonConvert.SerializeObject(libro);
                    File.WriteAllText(pathLibro, stringJson);
                }
            }
            catch (Exception e)
            {
                MensajeError(e);
            }
        }

        protected void GenerarListaJson()
        {

        }

        protected void MostrarJson()
        {

        }

        protected void LevantarListaJson()
        {

        }

        protected void MensajeError(Exception e)
        {
            AlertDialog.Builder dlgAlert = new AlertDialog.Builder(this);
            dlgAlert.SetTitle("Error");
            dlgAlert.SetMessage("Ocurrió el siguiente error" + e.Message);
            dlgAlert.SetCancelable(true);
            dlgAlert.SetPositiveButton("Aceptar", delegate { dlgAlert.Dispose(); });
            dlgAlert.Create();
            dlgAlert.Show();
        }
    }
}

