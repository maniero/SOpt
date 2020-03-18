public class VolatileRM : IEnlistmentNotification {
   private int oldMemberValue;
   public int MemberValue { get; 
       set {
           var currentTx = Transaction.Current;
           if (currentTx != null) {
               WriteLine("VolatileRM: SetMemberValue - EnlistVolatile");
               currentTx.EnlistVolatile(this, EnlistmentOptions.None);
           }
           oldMemberValue = MemberValue;
           MemberValue = value;
      }
   }

   public void Commit(Enlistment enlistment) {
       WriteLine("VolatileRM: Commit");
       oldMemberValue = 0;
   }

   public void InDoubt(Enlistment enlistment)  {
       WriteLine("VolatileRM: InDoubt");
   }

   public void Prepare(PreparingEnlistment preparingEnlistment) {
       WriteLine("VolatileRM: Prepare");
       preparingEnlistment.Prepared();
   }

   public void Rollback(Enlistment enlistment) {
       WriteLine("VolatileRM: Rollback");
       MemberValue = oldMemberValue;
       oldMemberValue = 0;
   }
}

//https://pt.stackoverflow.com/q/162465/101
