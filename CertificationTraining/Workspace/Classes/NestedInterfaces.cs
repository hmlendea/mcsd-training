using System;
using System.Collections.Generic;
using System.Linq;
namespace CertificationTraining.Workspace.Classes
{
    // This is the answer for Question 3, page 148 of Exam Ref

    /* 3. You have a class that implements two interfaces that both have a method with the
     * same name. Interface IA should be the default implementation. Interface IB should be
     * used only in special situations. How do you implement those interfaces?
     *
     * A. Implement IA implicitly and IB explicitly.
     * B. Implement both IA and IB explicitly.
     * C. Implement both IA and IB implicitly.
     * D. Implement IA explicitly and IB implicitly.
     */

    interface IB
    {
        void DoIt(int a);
    }

    interface IA
    {
        void DoIt(int a);
    }

    class Clasa : IA, IB
    {
        public void DoIt(int a)
        {

        }

        // You cannot use the 'public' modifier here
        // TODO: I don't know why, but I'll look into it
        // RESEARCH: Implicitly derived interfaces - access modifiers
        void IB.DoIt(int a)
        {

        }
    }
}
