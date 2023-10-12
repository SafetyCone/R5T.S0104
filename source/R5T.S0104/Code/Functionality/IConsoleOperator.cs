using System;

using R5T.T0132;


namespace R5T.S0104
{
    [FunctionalityMarker]
    public partial interface IConsoleOperator : IFunctionalityMarker,
        L0055.IConsoleOperator
    {
        /// <summary>
        /// Displays <see cref="Type.FullName"/> to the console.
        /// </summary>
        public void Display_Type_FullName(Type type)
        {
            var fullName = type.FullName;

            Console.WriteLine(fullName);
        }
    }
}
