txt = open(r'C:\Users\User\.PyCharmCE2019.1\config\scratches\penztar.txt', 'r')
osszeg = open(r'C:\Users\User\.PyCharmCE2019.1\config\scratches\osszeg.txt', 'w')
sor = txt.readline()
x = 0
f = 1
z = 1
arucikkek = dict()
termekek = {}
sorszam = int(input(""))
#darabszam = input("Darabszám: ")
'''
arucikk = input("Árucikk: ")
arucikk.lower()
arucikk += "\n"
sorszamok = []
'''
def ertek(p_darabszam):
    #darabszam = int(input("Darabszám: "))
    #p_darabszam = 0
    fizetendo = 0

    for i in range(p_darabszam):

        kedvezmeny= min(2, i)
        fizetendo += 500 - kedvezmeny * 50
    '''
    for i in range(darabszam):
        if i ==0:
            p_darabszam+=500
        if i ==1:
            p_darabszam+=450
        if i != 0 and i != 1:
            p_darabszam+=400
            print(i)
    '''

    return fizetendo
while(sor!=""):

    if(sor == "F\n"):
        z += 1
    sor = txt.readline()
txt.close()
txt = open(r'C:\Users\User\.PyCharmCE2019.1\config\scratches\penztar.txt', 'r')
while(sor!=""):

    if(sor == "F\n"):
        f += 1
    '''
    if sor != "F\n":
        if sor.strip() not in arucikkek.keys():
            arucikkek[sor.strip()] = [f]
        else:
            arucikkek[sor.strip()].append(f)

        #arucikkek[sor.strip()]=f

    #if sor==arucikk:
        #sorszamok.append(f)
    '''
    if f == sorszam and sor != "F\n":
        #print(sor)
        if sor.strip() not in termekek.keys():
            termekek[sor.strip()] = 1
        else:
            termekek[sor.strip()] += 1

    sor = txt.readline()
    '''
    print(sorszamok[0])
    print(sorszamok[-1])
    print("B",len(sorszamok))
    '''

    #print(termekek)
txt.close()
txt = open(r'C:\Users\User\.PyCharmCE2019.1\config\scratches\penztar.txt', 'r')

while(sor!=""):
    if(sor == "F\n"):
        f += 1
    if f == sorszam and sor != "F\n":
        #print(sor)
        if sor.strip() not in termekek.keys():
            termekek[sor.strip()] = 1
        else:
            termekek[sor.strip()] += 1
    for darabszam in termekek.values():
        x += ertek(p_darabszam=darabszam)
        x = str(x)
        x += "\n"
        osszeg.write(x)
    sor = txt.readline()
#print(type(x))
def fizetendo_vegosszeg(p_vasarlas_sorszama):
    txt = open(r'C:\Users\User\.PyCharmCE2019.1\config\scratches\penztar.txt', 'r')
    sor = txt.readline()
    f = 1
    termekek = {}

    while (sor!=""):

        if (sor == "F\n"):
            f += 1
        if f == p_vasarlas_sorszama and sor != "F\n":

            #print(sor)
            if sor.strip() not in termekek.keys():
                termekek[sor.strip()] = 1
            else:
                termekek[sor.strip()] += 1
        sor = txt.readline()
    txt.close()
    return termekek
def szamolo(vasarlas_sorszama):
    bevasarlas = fizetendo_vegosszeg(vasarlas_sorszama)
    vegeredmeny = 0
    for darabszam in bevasarlas.values():

        vegeredmeny += ertek(darabszam)
    return vegeredmeny
for vasarlas_szama in range(1, z):
    legvege = str(vasarlas_szama) + ": " + str(szamolo(vasarlas_szama))+"\n"
    osszeg.write(legvege)
#print(arucikkek)
txt.close()

osszeg.close()