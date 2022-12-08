using System.ComponentModel.DataAnnotations;

namespace Pokemon.Models
{
    public class Pokedex
    {
        [Key]
        [Display(Name = "ID")]
        public Guid Id { get; set; }

        //-------------------------Imagens do Frame-------------------------
        
        [Display(Name = "Default")]
        public byte[]? Default { get; set; }

        [Display(Name = "Shiny")]
        public byte[]? Shiny { get; set; }

        [Display(Name = "Megaevolução")]
        public byte[]? mega { get; set; }

        //-------------------------Informaçõe principais-------------------------
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [Display(Name = "Descrição")]
        public string? Descr { get; set; }

        [Display(Name = "Altura")]
        public double? altura { get; set; }

        [Display(Name = "Peso")]
        public double? Peso { get; set; }

        [Display(Name = "Espécie")]
        public string? sp { get; set; }

        //------------Tipos & Num-----------
        [Required(ErrorMessage = "É necessário informar o tipo Principal")]
        [Display(Name = "Tipo Principal")]
        public string Tipo1 { get; set; }

        [Display(Name = "Tipo Secundário")]
        public string Tipo2 { get; set; }

        [Display(Name = "Número")]
        public int num { get; set; }

        //-------------------------Informaçõe da Chart-------------------------
        [Display(Name = "HP")]
        public int? hp { get; set; }

        [Display(Name = "Ataque")]
        public int? atk { get; set; }

        [Display(Name ="Defesa")]
        public int? dfs { get; set; }

        [Display(Name = "Velocidade")]
        public int? vel { get; set; }

        [Display(Name = "Ataque Especial")]
        public int? atkE { get; set; }

        [Display(Name = "Defesa Especial")]
        public int? dfsE { get; set; }

        //-------------------------Movimentos-------------------------

        [Display(Name = "Movimento")]
        public string? move1 { get; set; }
        

        [Display(Name = "Movimento")]
        public string? move2 { get; set; }
        

        [Display(Name = "Movimento")]
        public string? move3 { get; set; }
        

        [Display(Name = "Movimento")]
        public string? move4 { get; set; }

        [Display(Name = "Movimento")]
        public string? move5 { get; set; }

        [Display(Name = "Movimento")]
        public string? move6 { get; set; }

        [Display(Name = "Movimento")]
        public string? move7 { get; set; }

        [Display(Name = "Movimento")]
        public string? move8 { get; set; }

    }
}
       