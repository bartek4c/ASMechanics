using Umbraco.Web;

namespace ASMechanics.Website.Core.UmbracoServices
{
    public interface IUmbracoService
    {
        /// <summary>
        /// Gets the umbraco helper.
        /// </summary>
        /// <value>
        /// The umbraco helper.
        /// </value>
        UmbracoHelper UmbracoHelper { get; }

        /// <summary>
        /// Gets the umbraco context.
        /// </summary>
        /// <value>
        /// The umbraco context.
        /// </value>
        UmbracoContext UmbracoContext { get; }
    }
}
