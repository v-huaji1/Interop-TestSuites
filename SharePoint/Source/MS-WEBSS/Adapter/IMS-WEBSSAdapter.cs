namespace Microsoft.Protocols.TestSuites.MS_WEBSS
{
    using System.Web.Services.Protocols;
    using System.Xml;
    using Microsoft.Protocols.TestSuites.Common;
    using Microsoft.Protocols.TestTools;

    /// <summary>
    /// Interface for the adapter of this test suite.
    /// </summary>
    public interface IMS_WEBSSAdapter : IAdapter
    {
        /// <summary>
        /// Initialize the services of WEBSS with the specified transport type, soap version and user authentication provided by the test case.
        /// </summary>
        /// <param name="transportType">The type of the connection</param>
        /// <param name="soapVersion">The format of the protocol message</param>
        /// <param name="userAuthentication">a user authenticated</param>
        /// <param name="serverRelativeUrl"> a Server related URL</param>
        void InitializeService(TransportProtocol transportType, SoapProtocolVersion soapVersion, UserAuthentication userAuthentication, string serverRelativeUrl);

        /// <summary>
        /// Initialize the services of WEBSS with the specified transport type, soap version and user authentication provided by the test case.
        /// </summary>
        /// <param name="userAuthentication">a user authenticated</param>
        void InitializeService(UserAuthentication userAuthentication);

        /// <summary>
        /// This operation is used to create a new content type on the context site
        /// </summary>
        /// <param name="displayName">displayName means the XML encoded name of content type to be created.</param>
        /// <param name="parentType">parentType used to indicate THe ID of a content type from which the content type to be created will inherit.</param>
        /// <param name="newFields">newFields is the container for a list of existing fields to be included in the content type.</param>
        /// <param name="contentTypeProperties">contentTypeProperties is the container for properties to set on the content type.</param>
        /// <returns>The result of CreateContentType.</returns>
        string CreateContentType(string displayName, string parentType, AddOrUpdateFieldsDefinition newFields, CreateContentTypeContentTypeProperties contentTypeProperties);

        /// <summary>
        /// This operation is used to enable customization of the specified cascading style sheet (CSS) for the context site.
        /// </summary>
        /// <param name="cssFile">cssFile specifies the name of one of the CSS files that resides in the default, central location on the server.</param>
        void CustomizeCss(string cssFile);

        /// <summary>
        /// This operation is used to remove a given content type from the site.
        /// </summary>
        /// <param name="contentTypeId">contentTypeId is the content type ID of the content type that is to be removed from the site.</param>
        /// <returns>The result of DeleteContentType.</returns>
        DeleteContentTypeResponseDeleteContentTypeResult DeleteContentType(string contentTypeId);

        /// <summary>
        /// This operation is used to get a list of activated features on the site and on the parent site collection.
        /// </summary>
        /// <returns>The result of GetActivedFeatures.</returns>
        string GetActivatedFeatures();

        /// <summary>
        /// This operation is used to get a list of the titles and URLs of all sites in the site collection.
        /// </summary>
        /// <returns>The result of GetAllSubWebCollection.</returns>
        GetAllSubWebCollectionResponseGetAllSubWebCollectionResult GetAllSubWebCollection();

        /// <summary>
        /// This operation is used to get the collection of column definitions for all the columns available on the context site. 
        /// </summary>
        /// <returns>The result of GetColumns.</returns>
        GetColumnsResponseGetColumnsResult GetColumns();

        /// <summary>
        /// This operation is used to get the collection of column definitions for all the columns available on the context site. 
        /// </summary>
        /// <param name="contentTypeId">contentTypeId is the ID of the content type to be returned.</param>
        /// <returns>The result of GetContentType.</returns>
        GetContentTypeResponseGetContentTypeResult GetContentType(string contentTypeId);

        /// <summary>
        /// This method retrieves all content types for a given context site.
        /// </summary>
        /// <returns>The result of GetContentTypes.</returns>
        GetContentTypesResponseGetContentTypesResult GetContentTypes();

        /// <summary>
        /// This operation obtains properties of the object referenced by the specified URL.
        /// </summary>
        /// <param name="objectUrl">The URL of the object from which to retrieve information.</param>
        /// <returns>The result of GetObjectIdFromUrl.</returns>
        GetObjectIdFromUrlResponseGetObjectIdFromUrlResult GetObjectIdFromUrl(string objectUrl);

        /// <summary>
        /// This operation is used to get the customization status (also known as the ghosted status) of the specified page or file.
        /// </summary>
        /// <param name="fileUrl">fileUrl is the URL of a page or file on the protocol server.</param>
        /// <returns>The result of GetCustomizedPageStatus</returns>
        CustomizedPageStatus GetCustomizedPageStatus(string fileUrl);

        /// <summary>
        /// This operation is used to get the collection of list template definitions for the context site.
        /// </summary>
        /// <returns>The result of GetListTemplates.</returns>
        GetListTemplatesResponseGetListTemplatesResult GetListTemplates();

        /// <summary>
        /// This operation is used to get the Title, URL, Description, Language, and theme properties of the specified site.
        /// </summary>
        /// <param name="webUrl">WebUrl is a string that contains the absolute URL of the site.</param>
        /// <returns>The result of GetWeb.</returns>
        GetWebResponseGetWebResult GetWeb(string webUrl);

        /// <summary>
        /// This operation is used to get the Title and URL properties of all immediate child sites of the context site. 
        /// </summary>
        /// <returns>The result of GetWebCollection.</returns>
        GetWebCollectionResponseGetWebCollectionResult GetWebCollection();

        /// <summary>
        /// This operation is used to remove an XML document in the XML document collection of a site content type.
        /// </summary>
        /// <param name="contentTypeId">contentTypeID is the content type ID of the site content type to be modified.</param>
        /// <param name="documentUri">documentUri is the namespace URI of the XML document of the site content type to remove</param>
        /// <returns>The result of RemoveContentTypeXmlDocument.</returns>
        RemoveContentTypeXmlDocumentResponseRemoveContentTypeXmlDocumentResult RemoveContentTypeXmlDocument(string contentTypeId, string documentUri);

        /// <summary>
        /// This operation is used to revert all pages within the context site to their original states. 
        /// </summary>
        void RevertAllFileContentStreams();

        /// <summary>
        /// This operation is used to revert the customizations of the context site defined by the given CSS file and return those customizations to the default style. 
        /// </summary>
        /// <param name="cssFile">cssFile specifies the name of one of the CSS files that resides in the default.</param>
        void RevertCss(string cssFile);

        /// <summary>
        /// This operation is used to revert the specified page within the context site to its original state.
        /// </summary>
        /// <param name="fileUrl">fileUrl is a string that contains the URL of the page.</param>
        void RevertFileContentStream(string fileUrl);

        /// <summary>
        /// This operation is used to perform the following operation on the context site and all child sites within its hierarchy.
        /// <ul>
        ///     <li>Adding one or more specified new columns</li>
        ///     <li>Updating one or more specified existing columns</li>
        ///     <li>Deleting one or more specified existing columns</li>
        /// </ul>
        /// </summary>
        /// <param name="newFields">newFields is an XML element that represents the collection of columns to be added to the context site and all child sites within its hierarchy.</param>
        /// <param name="updateFields">updateFields is an XML element that represents the collection of columns to be updated on the context site and all child sites within its hierarchy.</param>
        /// <param name="deleteFields">deleteFields is an XML element that represents the collection of columns to be deleted from the context site and all child sites within its hierarchy.</param>
        /// <returns>The result of UpdateColumns.</returns>
        UpdateColumnsResponseUpdateColumnsResult UpdateColumns(UpdateColumnsMethod[] newFields, UpdateColumnsMethod1[] updateFields, UpdateColumnsMethod2[] deleteFields);

        /// <summary>
        /// This operation is used to update a content type on the context site.
        /// </summary>
        /// <param name="contentTypeId">contentTypeID is the ID of the content type to be updated.</param>
        /// <param name="contentTypeProperties">properties is the container for properties to set on the content type.</param>
        /// <param name="newFields">newFields is the container for a list of existing fields to be included in the content type.</param>
        /// <param name="updateFields">updateFields is the container for a list of fields to be updated on the content type.</param>
        /// <param name="deleteFields">deleteFields is the container for a list of fields to be updated on the content type.</param>
        /// <returns>The result of UpdateContentType.</returns>
        UpdateContentTypeResponseUpdateContentTypeResult UpdateContentType(string contentTypeId, UpdateContentTypeContentTypeProperties contentTypeProperties, AddOrUpdateFieldsDefinition newFields, AddOrUpdateFieldsDefinition updateFields, DeleteFieldsDefinition deleteFields);

        /// <summary>
        /// This operation is used to add or update an XML document in the XML Document collection of a site content type.
        /// </summary>
        /// <param name="contentTypeId">contentTypeID is the content type ID of the site content type to be modified.</param>
        /// <param name="newDocument">newDocument is the XML document to be added to the site content type XML document collection.</param>
        /// <returns>The result of UpdateContentTypeXmlDocument.</returns>
        UpdateContentTypeXmlDocumentResponseUpdateContentTypeXmlDocumentResult UpdateContentTypeXmlDocument(string contentTypeId, XmlElement newDocument);

        /// <summary>
        /// This operation is used to get the URL of the parent site of the specified URL.
        /// </summary>
        /// <param name="pageUrl">PageUrl is a URL use to get its parent page URL.</param>
        /// <returns>The result of WebUrlFromPageUrl.</returns>
        string WebUrlFromPageUrl(string pageUrl);
    }
}