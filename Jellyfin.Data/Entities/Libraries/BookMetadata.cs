#pragma warning disable CA2227

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Jellyfin.Data.Interfaces;

namespace Jellyfin.Data.Entities.Libraries
{
    /// <summary>
    /// An entity containing metadata for a book.
    /// </summary>
    public class BookMetadata : ItemMetadata, IHasCompanies
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookMetadata"/> class.
        /// </summary>
        /// <param name="title">The title or name of the object.</param>
        /// <param name="language">ISO-639-3 3-character language codes.</param>
        public BookMetadata(string title, string language) : base(title, language)
        {
            Publishers = new HashSet<Company>();
        }

        /// <summary>
        /// Gets or sets the ISBN.
        /// </summary>
        public long? Isbn { get; set; }

        /// <summary>
        /// Gets or sets a collection of the publishers for this book.
        /// </summary>
        public virtual ICollection<Company> Publishers { get; protected set; }

        /// <inheritdoc />
        [NotMapped]
        public ICollection<Company> Companies => Publishers;
    }
}
