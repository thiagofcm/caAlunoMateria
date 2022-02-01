using System;
using System.Collections.Generic;
using System.Text;

namespace caAlunoMateria
{
    class Materia
    {
        // atributos
        private String nome;
        private String codigo;


        // metodos
        public Materia() { // construtor default
            nome = " ";
            codigo = " ";
        }
        public Materia(String _nome, String _codigo) { // construtor
            nome = _nome;
            codigo = _codigo;
        } 
        public String getNome() {
            return nome;
        }
        public void setNome( String _nome) {
            nome = _nome;
        }
        public String getCodigo() {
            return codigo;
        }
        public void setCodigo(String _codigo) {
            codigo = _codigo;
        }
    } // fim da classe materia
}
