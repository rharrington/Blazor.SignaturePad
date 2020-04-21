// Copyright (c) 2020 Allan Mobley. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Mobsites.Blazor
{
    public partial class SignaturePad
    {
        internal class Options : StatefulComponentOptions
        {
            /************************************************************************
            *
            *   Non-null enum and int members with a zero value do not need to be
            *   serialized as they would default to zero on C# object initialization.
            *   
            *   (For nullable types...well null is null.)
            *
            *   Setting their options equivalent to null will keep them from
            *   being serialized.
            *
            *   This saves space in browser storage.
            *
            *   Caveat: If the options are passed into a javascript function,
            *   then, obviously, any such members depended on there will have to 
            *   be accounted for there as not defined.
            *
            ***********************************************************************/
            
            public bool Destroy { get; set; }
            public SignaturePadFooter.Options SignaturePadFooter { get; set; }
            public SignaturePadPen.Options SignaturePadPen { get; set; }
            public SignaturePadClear.Options SignaturePadClear { get; set; }
            public SignaturePadUndo.Options SignaturePadUndo { get; set; }
            public SignaturePadSave.Options SignaturePadSave { get; set; }
        }
    }
}