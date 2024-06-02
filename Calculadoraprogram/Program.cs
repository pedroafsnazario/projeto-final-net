using System;
using System.Collections.Generic;
using System.Text;



public class Calculadora{

    private List<string> listahistorico;
    private string data;

    public Calculadora(string data) {
        listahistorico = new List<string>();
        this.data = data;
    }
    
    public int somar(int valor1, int valor2){

        int res = valor1 + valor2;
        listahistorico.Insert(0, "Res: " + res + " - data: " + data);
        return res;

    }

    public int subtrair(int valor1, int valor2){
        int res = valor1 - valor2;
        listahistorico.Insert(0, "Res: " + res + " - data: " + data);
        return res;
    }

    public int dividir(int valor1, int valor2){
        int res = valor1 / valor2;
        listahistorico.Insert(0, "Res: " + res + " - data: " + data);
        return res;
    }

    public int multiplicar(int valor1, int valor2){
        int res = valor1 * valor2;
        listahistorico.Insert(0, "Res: " + res + " - data: " + data);
        return res;
    }

    public List<string> historico() {
        
        listahistorico.RemoveRange(3, listahistorico.Count - 3);
        return listahistorico;
    }

}



