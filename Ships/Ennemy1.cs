
public class Ennemy1 : EnnemyParent
{
    public Ennemy1(int pPosX, int pPosY) : base(pPosX, pPosY)
    {
        this.isAlive = true;
        this.life = 3;
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

