namespace blazorserver01.Data
{
    public class BioUnit
    {

        protected string color;
        protected int living;
        protected int livingTop;
        protected int hungry;
        protected int hungryTop;

        public int posx;
        public int posy;
        public Environment parent;

        public BioUnit(int x, int y, Environment e) {
            this.posx = x;
            this.posy = y;
            this.color = "#4FEA00";
            this.parent = e;
        }

        public string myColor() => this.color;
        public virtual bool will_I_live() => true;


       /* private bool alive; 
        public BioUnit() {
            this.alive = false;
        }
        public bool is_alive() {
            return this.alive;
        }
        public bool is_dead() {
            return !this.alive;
        }
        public void live() {
            this.alive = true;
        }
        public void die() {
            this.alive = false;
        }*/
    }
}