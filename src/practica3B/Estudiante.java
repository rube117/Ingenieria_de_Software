/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practica3B;

/**
 *
 * @author Rubén
 */
public abstract class Estudiante extends Persona {
    

    public abstract void nivel();
    
    @Override
    public void ocupacion() {
        setTipo("Estudiante");
    }

}
