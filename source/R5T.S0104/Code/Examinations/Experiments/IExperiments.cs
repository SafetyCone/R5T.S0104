using System;

using R5T.T0141;
using R5T.T0225.T000;


namespace R5T.S0104
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public void WhatIs_DelegateTypeName_EventHandler()
        {
            var type =
                // System.EventHandler
                typeof(EventHandler)
                ;

            Instances.ConsoleOperator.Display_Type_FullName(type);
        }

        public void WhatIs_ClosedGenericTypeName()
        {
            var type =
                // System.Collections.Generic.IDictionary`2[
                // [System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],
                // [System.Int32, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]
                // ]
                typeof(System.Collections.Generic.IDictionary<string, int>)
                ;

            Instances.ConsoleOperator.Display_Type_FullName(type);
        }

        public void WhatIs_NestedTypeName()
        {
            var type =
                // R5T.T0225.T000.NestedType_001_Parent+NestedType_001_Child
                typeof(NestedClass_001_Parent.NestedClass_001)
                ;

            Instances.ConsoleOperator.Display_Type_FullName(type);
        }

        public void WhatIs_OpenGenericTypeName()
        {
            var type =
                // System.Collections.Generic.IEnumerable`1
                typeof(System.Collections.Generic.IEnumerable<>)
                ;

            Instances.ConsoleOperator.Display_Type_FullName(type);
        }
    }
}
