/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package actividad2;

/**
 *
 * @author Rubén
 */
public abstract class Persona {

    private String nombre;
    private String nivel_de_estudio;
    private String profesion;
    private byte edad;

    public abstract void ocupacion();

    public Persona() {
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNivel_de_estudio() {
        return nivel_de_estudio;
    }

    public void setNivel_de_estudio(String lugar_de_estudio) {
        this.nivel_de_estudio = lugar_de_estudio;
    }

    public String getProfesion() {
        return profesion;
    }

    public void setProfesion(String profesion) {
        this.profesion = profesion;
    }

    public byte getEdad() {
        return edad;
    }

    public void setEdad(byte edad) {
        this.edad = edad;
    }
}
