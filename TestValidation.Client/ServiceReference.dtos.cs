/* Options:
Date: 2018-04-14 20:07:59
Version: 5.00
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: http://localhost:8088

//GlobalNamespace: 
//MakePartial: True
//MakeVirtual: True
//MakeInternal: False
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: False
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: True
//ExportValueTypes: False
//IncludeTypes: 
//ExcludeTypes: 
//AddNamespaces: 
//AddDefaultXmlNamespace: http://schemas.servicestack.net/types
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using TestValidation.Server;


namespace TestValidation.Server
{

    [Route("/hello")]
    [Route("/hello/{Name}")]
    public partial class Hello
        : IReturn<HelloResponse>
    {
        public virtual string Name { get; set; }
    }

    public partial class HelloResponse
    {
        public virtual string Result { get; set; }
    }
}

