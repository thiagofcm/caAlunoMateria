using System;
using System.Collections.Generic;
using System.Text;

namespace caAlunoMateria
{
    class Aluno
    {
        // atributos
        private String nome;
        private String numero_matricula;
        private int periodo;
        int qtd_materias;
        Materia[] lista_materias = new Materia[8];



        // metodos

        public void adicionarMateria(Materia m) {
            lista_materias[qtd_materias] = new Materia(m.getNome(), m.getCodigo());
            qtd_materias++;
        }
        public Aluno() { // construtor default
            nome = " ";
            numero_matricula = " ";
            periodo = 0;
            qtd_materias = 0;
        }

        public Aluno(String _nome, String _numero_matricula, int _periodo) {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
        }

        public String getNome() {
            return nome;
        }
        public void setNome(String _nome) {
            nome = _nome;
        }
         
    } // fim da classe aluno
}
