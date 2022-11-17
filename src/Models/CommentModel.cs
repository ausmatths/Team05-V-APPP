namespace ContosoCrafts.WebSite.Models
{
    /// <summary>
    /// Comments entered by the user about the Product
    /// </summary>
    public class CommentModel
    {
        /// <summary>
        /// The ID for this comment, use a Guid so it is always unique
        /// </summary>
        public string Id { get; set; } = System.Guid.NewGuid().ToString();

        /// <summary>
        /// The Comment getter setter
        /// </summary>
        public string Comment { get; set; }
    }
}