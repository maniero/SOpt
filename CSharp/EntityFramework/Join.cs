var qry = db.User.Join(db.Solicitation, user => user.UserID, sol => sol.UserID, (user, sol) => new { user, sol })
                .Join(db.Payments, sol => sol.sol.SolicitationID, py => py.SolicitationID, (sol, py) => new { sol, py })
                .Join(db.RefundKM, sol => sol.sol.sol.SolicitationID, km => km.SolicitationID, (sol, km) => new { sol, km })
                .Join(db.Refund, sol => sol.sol.sol.sol.SolicitationID, re => re.SolicitationID, (sol, re) => new { sol, re })
                .Select(syn => new {
                    EmployeeID = syn.sol.sol.sol.user.EmployeeID,
                    EmployeeStatus = syn.sol.sol.sol.user.EmployeeStatus,
                    EmployeeFirstName = syn.sol.sol.sol.user.EmployeeFirstName,
                    Grade = syn.sol.sol.sol.user.Grade,
                    SolicitationID = syn.sol.sol.sol.sol.SolicitationID,
                    StatusSolicitation = syn.sol.sol.sol.sol.StatusSolicitation,
                    DateFinancing = syn.sol.sol.sol.sol.DateFinancing,
                    Manufacturer = syn.sol.sol.sol.sol.Manufacturer,
                    Chassi = syn.sol.sol.sol.sol.Chassi,
                    Model = syn.sol.sol.sol.sol.Model,
                    ValueProperty = syn.sol.sol.sol.sol.ValueProperty,
                    ValueGranted = syn.sol.sol.sol.sol.ValueGranted,
                    PaymentStatus = syn.sol.sol.py.PaymentStatus,
                    ValuePayment = syn.sol.sol.py.ValuePayment,
                    ValueInterest = syn.sol.sol.py.ValueInterest,
                    ValuePayment = syn.sol.km.ValuePayment,
                    ValuePaymentRe = syn.re.ValuePayment
                });
                
//https://pt.stackoverflow.com/q/330153/101
