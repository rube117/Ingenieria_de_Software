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
public class Imc {

    private Persona persona;

    public float CalculoIMC() {
        // Aquí se puede calcular el IMC
        return (float) (persona.getPeso() / (persona.getEstatura() * persona.getEstatura()));
    }

    public Persona getPersona() {
        return persona;
    }

    public void setPersona(Persona persona) {
        this.persona = persona;
    }

}
