public class Ennemy2 : EnnemyParent
{
    public Ennemy2(int pPosX, int pPosY) : base(pPosX, pPosY)
    {
        this.isAlive = true;
        this.life = 4;
        this.posX = pPosX;
        this.posY = pPosY;
    }
    public override void TakeDamage()
    {
        life--;
    }
    protected override bool IsDead()
    {
        if (life <= 0)
        {
            return true;
        }
        return base.IsDead();
    }
}

