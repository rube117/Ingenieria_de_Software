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
public class Empleado extends Persona{
    
    private float salario;
    
    @Override
    public void ocupacion() {
        
    }

    public float getSalario() {
        return salario;
    }

    public void setSalario(float salario) {
        this.salario = salario;
    }

}
