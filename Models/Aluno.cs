using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_mvc.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }    
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string Curso { get; set; }
        private List<Aluno> _listaAluno { get; set; }


        public void CriarAluno(){
            try
            {
                 _listaAluno = new List<Aluno>()
            {
                new Aluno(){ Id = 1,Nome= "Paulo",Idade=29, Genero = 'M', Curso="Ciência da Computação"},
                new Aluno(){ Id = 2,Nome= "Alexandre",Idade=20, Genero = 'M', Curso="Economia"},
                new Aluno(){ Id = 3,Nome= "Carlos",Idade=25, Genero = 'M', Curso="Ciências Contábeis"},
                new Aluno(){ Id = 4,Nome= "Bianca",Idade=25, Genero = 'F', Curso="Ciência da Computação"},
                new Aluno(){ Id = 5,Nome= "Laura",Idade=35, Genero = 'F', Curso="Literatura"}
            };
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public List<Aluno> BuscarAluno()
        {
            try
            {
                return _listaAluno;
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}