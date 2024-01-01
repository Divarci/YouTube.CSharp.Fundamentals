//ATTRIBUTES

//We use attributes to give specifications to our props, classes and/or methods.

using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

[Authorize]
class Example
{
    [Required]
    public int MyProperty { get; set; }

    [Obsolete]
    void Method()
    {

    }
}

//Attributes keep the data, they do not do logics.

//-----continue with reflection example 2 ----------