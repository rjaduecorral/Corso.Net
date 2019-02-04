using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.Net.BusinesLogic
{
    public class TransactionManager
    {
        public ITransactionFactory Factory { get; } //questo è una property: livelloDiAcceso TipoDiDato Nome

        // il "{get;}" ti da il valore di quella property. Il {set;} invece permete le modifiche su quella property

        public List<ITransazione> Transazioni { get; }

        public TransactionManager(ITransactionFactory factory) 
       //questo è il costruttore e serve per istanziari gli oggetti di una certa classe 
        {
            Factory = factory;
            Transazioni = new List<ITransazione>();
        }

     
        public ITransazione CreateTransaction()  // stiamo creando un metodo che non prende nulla di input <()>
        {
            return Factory.Create();
            // con questo metodo ottengo un risultato di tipo ITransazione
        }

        public void SaveTransaction(ITransazione transazione)
        {
            Transazioni.Add(transazione);
        }

        public ITransazione DeleteTransaction(int index)
        {
            return null;
        }

        public IEnumerable<ITransazione> GetTransactions()
        {
            return null;
        }

    }
}
