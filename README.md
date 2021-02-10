Console Application<br>
Exercise: Stacks and Queues
# KeyRevolver
Our favorite super-spy action hero Sam is back from his mission in another exam, and this time he has an even more difficult task. He needs to __unlock a safe__. The problem is that the safe is __locked__ by __several locks in a row__, which all have __varying sizes__.<br><br>
Our hero posesses a special weapon though, called the __Key Revolver__, with special bullets. Each __bullet__ can unlock a __lock__ with a __size equal to or larger than__ the __size__ of the __bullet__. The bullet goes into the keyhole, then explodes, completely __destroying__ it. Sam __doesn’t know the size__ of the locks, so he needs to just shoot at all of them, until the safe runs out of locks.<br><br>
What’s behind the safe, you ask? Well, intelligence! It is told that Sam’s sworn enemy – __Nikoladze__, keeps his __top secret Georgian Chacha Brandy__ recipe inside. It’s valued differently across different times of the year, so Sam’s boss will tell him what it’s worth over the radio. One last thing, every bullet Sam fires will also cost him money, __which will be deducted from his pay__ from the price of the intelligence.
## Input
- On the __first line__ of input, you will receive the price of each __bullet__ – an __integer in the range [0-100]__
- On the __second line__, you will receive the __size of the gun barrel__ – an __integer in the range [1-5000]__
-	On the __third line__, you will receive the __bullets__ – a __space-separated integer sequence__ with __[1-100] integers__
-	On the __fourth line__, you will receive the __locks__ – a __space-separated integer sequence__ with __[1-100] integers__
-	On the __fifth line__, you will receive the __value of the intelligence__ – an __integer in the range [1-100000]__
After Sam receives all of his information and gear (__input__), he starts to __shoot the locks front-to-back__, while going through the bullets __back-to-front__.<br><br>
If the __bullet__ has a __smaller or equal__ size to the __current lock__, print "__Bang!__", then __remove the lock__. If not, print "__Ping!__", leaving the lock __intact__. The bullet is removed in __both cases__.<br><br>
If Sam runs out of bullets in his barrel, print "__Reloading!__" on the console, then continue shooting. If there aren’t any bullets left, __don’t__ print it.<br><br>
The program ends when Sam __either runs out of bullets__, or the safe __runs out of locks__.
## Output
- If Sam __runs out of bullets__ before the safe runs out of __locks__, print:
"__Couldn't get through. Locks left: {locksLeft}__"
-	If Sam manages to __open the safe__, print:
"__{bulletsLeft} bullets left. Earned ${moneyEarned}__"<br>
Make sure to account for the __price of the bullets__ when calculating the __money earned__.
## Constraints
-	The input will be __within the constaints__ specified above and will __always be valid__. There is __no need__ to check it explicitly.
-	There will __never__ be a case where Sam breaks the lock and ends up with а __negative balance__.
## Examples
Input|Output|Comments
-----|------|--------
50<br>2<br>11 10 5 11 10 20<br>15 13 16<br>1500|Ping!<br>Bang!<br>Reloading!<br>Bang!<br>Bang!<br>Reloading!<br>2 bullets left. Earned $1300|20 shoots lock 15 (ping)<br>10 shoots lock 15 (bang)<br>11 shoots lock 13 (bang)<br> 5 shoots lock 16 (bang)<br><br>Bullet cost: 4 * 50 = $200<br>Earned: 1500 – 200 = $1300
20<br>6<br>14 13 12 11 10 5<br>13 3 11 10<br>800|Bang!<br>Ping!<br>Ping!<br>Ping!<br>Ping!<br>Ping!<br>Couldn't get through. Locks left: 3|5 shoots lock 13 (bang)<br>10 shoots lock  3 (ping)<br>11 shoots lock  3 (ping)<br>12 shoots lock  3 (ping)<br>13 shoots lock  3 (ping)<br>14 shoots lock  3 (ping)
33<br>1<br>12 11 10<br>10 20 30<br>100|Bang!<br>Reloading!<br>Bang!<br>Reloading!<br>Bang!<br>0 bullets left. Earned $1|10 shoots lock 10 (bang)<br>11 shoots lock 20 (bang)<br>12 shoots lock 30 (bang)<br><br>Bullet cost: 3 * 33 = $99<br>Earned: 100 – 99 = $1
