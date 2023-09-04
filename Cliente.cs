namespace exercicio_090223 {
    public class Cliente {
        // Atributos
        public String nome;
        public double saldo;

        // Métodos
        public void aumentarSaldo(double valor) {
            //this.saldo = this.saldo + valor;
            this.saldo += valor;
        }
    }
}