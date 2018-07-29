﻿
namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um endereço de uma empresa no sistema
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// Identificador único do endereço
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Cidade do endereço
        /// </summary>
        public string Cidade { get; set; }
        /// <summary>
        /// Rua do endereço
        /// </summary>
        public string Rua { get; set; }
        /// <summary>
        /// Número da rua
        /// </summary>
        public int numero { get; set; }
        /// <summary>
        /// Sala ou salas do edifício
        /// </summary>
        public string Sala { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Estado deste endereço
        /// </summary>
        public virtual Estado Estado { get; set; }

        #endregion
    }
}
