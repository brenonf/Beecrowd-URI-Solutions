import datetime
def entrada():
    m,d = map(int,input().split())
    return m,d

def diferenca(m,d):
    natal = datetime.date(day = 25, month = 12, year = 2016)
    data = datetime.date(day = d,month = m, year = 2016)

    delta = natal - data
    dias = delta.days

    return dias

def main():
    while True:
        try:
            m,d = entrada()
            dias = diferenca(m,d)
            if dias == 1:
                print('E vespera de natal!')
            elif dias > 1:
                print('Faltam {} dias para o natal!'.format(dias))
            elif dias == 0:
                print('E natal!')
            elif dias < 0:
                print('Ja passou!')
    


        except EOFError:
            break

main()