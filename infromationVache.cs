using System.ComponentModel.DataAnnotations;

namespace CoreNet_Project_2_Web_Avancer.Models
{
    public class InformationVache
    {
        public int Id { get; set; }
        public string? Description { get; set; }


        [Required(ErrorMessage = "Veuillez entrer le nombre du budget.")]
        public int Budget { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une date de naissance.")]
        public string? DateDeNaissance { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire.")]
        public string? Telephone { get; set; }

        [Required(ErrorMessage = "Veuillez entrer le nombre de vaches.")]
        public int NombreDeVache { get; set; }

    }
}
