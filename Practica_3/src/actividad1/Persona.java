/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package actividad1;

/**
 *
 * @author Rubén
 */
public class Persona {

    private String nombre;
    private String ocupacion;
    private String lugar_de_estudio;
    private String profesion;
    private float peso;
    private float estatura;
    private byte edad;

    public Persona() {
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getOcupacion() {
        return ocupacion;
    }

    public void setOcupacion(String ocupacion) {
        this.ocupacion = ocupacion;
    }

    public String getLugar_de_estudio() {
        return lugar_de_estudio;
    }

    public void setLugar_de_estudio(String lugar_de_estudio) {
        this.lugar_de_estudio = lugar_de_estudio;
    }

    public String getProfesion() {
        return profesion;
    }

    public void setProfesion(String profesion) {
        this.profesion = profesion;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public float getEstatura() {
        return estatura;
    }

    public void setEstatura(float estatura) {
        this.estatura = estatura;
    }

    public byte getEdad() {
        return edad;
    }

    public void setEdad(byte edad) {
        this.edad = edad;
    }
    
    public float CalculoIMC() {
        // Aquí se puede calcular el IMC
        return (float) (getPeso() / (getEstatura() * getEstatura()));
    }

    public String Checar_Edad() {
        String retorno;
        if (this.edad >= 18) {
            retorno = "Es mayor de edad.";
        } else {
            retorno = "Es menor de edad.";
        }
        return retorno;
    }
}
