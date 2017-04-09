﻿using AcManager.Tools.About;
using System.Linq;

namespace AcManager.About {
    public static class ImportantTips {
        public static readonly PieceOfInformation[] Entries = new []{
            new PieceOfInformation(@"22_-1950881468_1645627313", null, @"Command-Line Arguments", null, null, @"bVPBatwwEL3vVww5JRDboS0UWvawpCkNJN1LKBTHB1melVUkjSrJyRp6WOgv9NIf6E/00H/ZH+gvdORuQjA52pp5782bN39//zm/hl5EENAOTvZAG4gepRYGyCdNLsJIA0jhIGKCdoQhaqdAkrXCdYXRDkEENVh0KZawDvBliAlkQJH4BRzeQ62b1WNJ2qa60g1stEHQLj/ud79uV96/E0ncXpEU5nYlb4hMhHNyibvgWjihMEyNTAv3QTN66tFmCJ3gmJ7oAI8BsrKTcrHY777X2qrlUZ+Sf1NVuuSvIZQ8QfV1/ZrWn1zpnfr24tXZUXOxFdazLrYh9SJNIpnUqmax+IAhUyBEsoeKJ6O/mYjaprbkqCkKrRwFLOIYE9rCB9qOy40wkeGmirpqG9jvfrCfCNNzNjixtxE2gSxc8uTBsecXW28YKrydMXQ6itZgYUgpbpvj8hgi4il05Pa7n2niYaMc3Z+C8J43OJiO9yRinz0UboSkLTdkfxkzHipahDsMI/Ro/GYwcxUxUeDVsAopcl6WV+vz1c3l+uNcj+yFUwgPddnAjhcOGzIdr+uYv5kwZMmp1xHyQmP/IIHVd/zLjDCF9dn4ncy1ebalkOTkEAI6OS5fns1VucG2zJ5jj4HnjEyW851bmfGxOZlxjo5usj8IiYV2ugg4eTGZ8OymHzYRkInSwZB4uIEMUzJMjjin9vPj0U0xB3becKT5suohmP9hjpxmpVM/tFOYVaCC7rASMuXbqVpDbWUF5y9UK3m4oIrv7L0RqpTxqOk50XXFeE35Dw==", false, false),
            new PieceOfInformation(@"23_1914836418_-1434887878", null, @"Custom Weather’s Clouds", null, null, @"TVLLihRBELzPV6Rz2oWx25VFcEF0cQVXUAbUi0Mfqrtzpsutqmwqq6ZnxMP+hqDgf3gQ/JT9AX/B6B5GvfSjKjMiMiJ///j5RgbaS6bGBFJOpD031jhqnORWaS2RTNjTwCZ1HO/NZr++r6zfPJl3KfUXZWkL/OVYNOLL85fX2/zpQ/Gx33x+eP5gXr3YGd87XpWoqWazZU4EFE82JKGVrQ4kuK5A5FqOuFHb8pHu7vaL0vHKhJaev6bBOkeRe2caJol2Y8M/uSYn8SbZxji3L+gytAuSNTWSo/Li2LvlmGh87lNnw4Zq09wQFAWJHlhmnUAHfoojx4nEBXTBIeURTHPbciDe2TSdGwq8g3HJxJT702I2e5U1HTsWALJKNXdma2EmpLgWv9RaNbXjdix8yylBiJZX0W4ZCO86E2501LTK0f01exiGwihiStJIVFMETiUiyr60oeVd0Xf9U8++5qhlzxjjfi2sXJw9Ontczqtn0xlNZ6sSyNUU8DgqXDdId1VX75dXF3jRuBk2kXEqmLnvJSalBqOJp+WS1tYBC5Yr0nKuoGnqHhGb8Y4pGI/p7m6/HioLG+zd7beDY//ne4gXQ1+CaUFm2hHy4jkcPodOAKd7TVidFtoD+hINEm+QaOpIgrNhbMHmnKgNCE05bkd1rRyKEyQCyDbdkXuE3lNWPi3oGjWeUtyP2wDT13ATKlVcTlYC1ZgqCDLOEU6tYcukvBdViwxHzVi44g8=", false, false),
            new PieceOfInformation(@"17_-113008927_-924009265", @"iNeedYourHelp", @"Thank you!", null, null, @"PZFBbtswEEX3PsU4qxi1JTQtijZAURhBFkE3AZSd4cWYHFWEKY7CGUbJrtfoWbroXXqBXqEjOfGSBPnfmz//fv956DAd4YULYIzQcgYpw8BZl3CnMHI+yhKuV4vFTvZNSI5gewPvq0/QNLcgygP5+VVIP9aAyQNrRxl0ZLh8yMEdX+bbRjEr5XcryPRYQiYYc1DaoHMkAsqQmXXKbjl6ymsYu+A6cFyihwNBSfiEIeIhUgXbKLyGg6GAWzBgf461A3hqsUSFiCW5yeZyK0KqfMNZsKJnWk1ES800RHTkT+pBX3kOixAI95aXuRhTqsWiMebd35+/ekCZ5oXvJfHsjt6fXnPbBhcwvpU4F+qK9dSfbaSCXcnx60WnOlzX9TiOFZ783OyXSGv7V/o6JE/P1dAN37TLhF5qjNZiQg1PtDkHbt6wm1ds9eHq85eP9cX+PhIKrUE6Hq0a1GnTNoIVFZIlkajtLyQbfbmrzWq/q2X/Hw==", false, true),
            new PieceOfInformation(@"21_1095401383_1831013213", @"trackPreviews", @"Track Previews How-To", null, null, @"ZVJBbhNBELz7FU1ORLK8BxSBEnGwDIEIHyJQTlEO7Z22d+LZ6WGmxxtHHCzxCiRy4Rsc+Mt+IF9Iz1oYBNJKs7PdVV1dtY8/f10sYcsZOvQCwrAiTxGFAMFTByHSxuppW1wRLDkC+i1IxHoNeukIpaE4Ln0pQb/7fhVMQV/ucf3uARZZhD3oo61gJYH1MGMvVCbiYgIfsSborHOwIEiCUcgAJsgpoxsXAoUkITTASzDRbqxfDao9aaeqbnGtSG4Jgq0lq5jPWT80rNOea2O/+7Znx4WjAqgb5kQqigqlCmvBqe54PBmN3lsv6XTU7772ux9lE93s/NVhDA68Z//UX5Z66qzUTXlDOI9EMMNW3YSWDQ06oEYP5AcVtmwF0xkkEtGF0vGB88L/D88qF2PkLg1KeENKNpQxcvbmDNAlHlxpcQsNOwMzia7E9KmxyyFdNLc5yRBCCurdYeLUm/Ffll9q2lehKscb7rxSO+4KgWR1jO4CJzX5DzqEfX61RoXegHpi72nv6+BbseVD9px+/1EJMAtrwdZKvlXblevatqvXR41IOK0qO9FbjpOa22p+P5/fTrtJ8KsvL05Ojm7e3mEbHF1X2nMzGr1jNuByvX72BA==", true, false),
            new PieceOfInformation(@"8_-1601734236_1588375622", @"starters", @"Starters", null, null, @"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", false, false),
        }.Where(x => !x.IsHidden).ToArray();
    }

    public static class Licenses {
        public static readonly PieceOfInformation[] Entries = new []{
            new PieceOfInformation(@"20_1348168051_-1001197761", null, @"WPF Adorners in XAML", @"AdornedControl", @"https://www.codeproject.com/articles/54472/defining-wpf-adorners-in-xaml", @"pVrdcuM4dr7vp0D5Zt1VtCeTVGWTnStaom1mZElLSfY4d5QIWUhTpBYg7Vau8hp5llzkXfICeYV85wAgQVlu72yqutoUCOD84Jzv/ID/+1//Pdcy369L+eXLcqeMmKiNrIwUL/Wr1JURz3WrRYuBeiuanRRPtf52LQZT8aiqRlaFLERTi7ws6zdRyFdZ1gepDY3RBrR6gd02UozqQoq8KkTyXW7aJgd5catKacRB16+KNsrxnOsmJAsqWHQU+eFQqk3eqLryQ9ta769JAin2OcYONTgywrTrf5ObhjigTRqp98bv6LnPtfzTl6vPOdvklVhLkqQgqpt6v5d6o/Iy5Mf88ju20rJQptFq3Tay+IWmnix28/Z1obbKKneD02oktKvVKyi+SvEGzZhrrJzibZmrPQloWgWCqlTNMRIvba5zHJCMRK1ZXW+5phE87PLG1DgqTafolU/nK4Wptw0myvCNuMjNlTIXRI/mxLpRm1Jemq8i30AlB+yuqpf+yPb5UVR1Q2IEwhIfWh7adanMDj/fVLOr24aXxS2e9R+gJahTVg1TGlobRiWUh02bNykrstGI16qqUOCzxaGAQo0hTZOhBZDLC+LMj78pQ7byjcZOzFuUllQhDq02LRRlDShggo71E4JvO7XZYdstu4DfuoWX6FNjDDa+vLDyX3yFObtB2PV9Ip5m2a/iMl6IcXKbTpOxuEkms6evIl2IeTZ7TMcYWk3HSSZo9jLJHhZidosfmDCajROa9S/JaClm82QqJukomS4S0HNPICg6MnbPJWYTnWesnz9n6d39UsTT8U+zTMwwNRPxfI7V8c0kEZP46Rovn8UKmzJZt5WdubyPpwK8x6vl/SxL/zXgFbQ8M9i4p4QdHR/36U0KRqAQsJL8lmSjdJFO75gcz12I5ayn2GkDhJN0Gonn2UrEo1EyZ/ZFfJclCa24ScTNDGyQhO915piyWrF8i7ssnoIabUijjvhoNl3GfCSWosA/jC3ARBYv09mU9sSazHERT0eso8VqdO+IEl9YMk5p+uJapLxAjGdiOlv2HAdS/FXMW9lH8ZR2eYh/Tc4dEfQ6lltVKQYw/LoSF86vzYXYy7wyEZyxLIGkAJwSiAKIB27aKeJNqwboL9ZH57vO9AtpNvB3zNghHvxV6A8YH0KHB1zsndOTvmburItY3s74ofPABuD2ex2Q9x/36EprPKGcsVasc+KoPSD6dLuC6HCAxLNwcNDySn4H9hHSdGB9cSr7BRBqS5zZUCW711D+WlW5RpBT/Au4uFUvrbYBkAgRpGv5l1YRKBZ5k9up0MqmbAsbr7rYTcTnDnkHOnQYrz0Uvsm1UQ2Cxj5/yf9dVXgaja+y2UMkxo/jHu/2CGPtXmx1vafBtYe+PmxDy+sGYdkeJNCamQiswQlvvPTe2iAfBTM7cePNZqgAKypbSR8faZNTDVuiDXbIdSEeQQ7LQ8qmBde543krVCN2yEJs9IJ9+zDMUZTeDEY5E0EI1EVegVmKaE4UjmJeqdZ0I0vLv1tLsg13SFdi28K9EC0hi1dBv5SlsFb5I51ZrYQhd33kad3RR848fLgOjiN6pztng4qeegPDc71p9xCBjyKig2/kIees76oLkh5MmHWc/gVZxJFidl6d91wE5x3z1WeOnVfBM5B2YfRImalWLzsket6rQ0f+cpsrLVZG/uQfRMazr5EqNbtO5R9nsnCndgNtlGqvmsgmLaRQZJTscpY21GJoM3aALZECz5F9KmRe4h1+KW0aYXIotHMc3tamjcJhh/yOIzEEPG5zd/ab+nDkEVG/VVhq5e1Hy/yt39flo3R4GDd9IiHuKOu7FotzabHzrEI5hoa4GAUmKEBEwpxeaDeuECw0lsWbIuPR9TEvm+PVVlPKWdXVVSdWJGAbB9nQcV96tC+8KzthA/47Cb/6pIyY7kyAZjtFqRB8kflDsZwhohb5E4U04pIiircn44Hg1QKBJx7GKPD3LkSpypZEOIdB4n8d0KBxxK4WNqG+k5scau3TcTsUxAcLIBtvBx4o2Zo6h92Icc2FDVjq3jhAELGLlwESOSh7AzNmR9Ea4Qf/ry0eEcrL4rwaiLE3N3dQPg1jpBc1yKWJ/NEqh46tsyBm7pJNoAMbDwlffQFHnPbwnYuTEBz1FQhHdSKvwAoKxJxe7aEzACmwGizSnjInfN3l1QvpEifHFkHkkYwQUEknKtkyb+cn8/60IhSzB9IfGs87ayESJxZ1Ihkr4OVFyxcSnMOGtYvLQ22MWsOQ+lLzK8kKtyN37evjHG6uXz5c0tVxnRDg+KSA41CxaY0ZFG99gRaU2T6Q5BYL/v8Fnq023XYIeTBzE0AbdRRAmi26iyTv3PlTzX9YyoFfCiWdIGC7BlSHAgyLxsAWWP5vYP41VyUTD407Goh90IpSY5csn00LgNQxi7rWWAWTNkyhLlqSyLQEN10OxRIiuHzj43FQ/hl6DXzSIoM7vAAX+r6Ln9mBgpv8cV9lEIDnMGnI6Af+trjDnnw28GAbG3u6mBKFYegk8FT1FVwcfnIaoJTW8rW28YZgSh6aIIL4FMHY3AoeaIUKwhGZQISM8JUaCkSZ47/aE+pHPdKz8TRg3WxlX+ZATZlLKjiMsDP4zVlQy8TC5Xb/IPJ1/WrbIN9RWxgDdyey4aFY00B20ed925racuTeOiDXhcYcCCT5eDnv2RMJcjtnnzV8EQlg2ftl5BQRkUiF3OcE0lyMNB3IODy2Z5wbUwOQiCXCGupU2cIMcOuCpsy1j+OfGPL1ObbzAnDckJZrHcYVnETpqsHepJWxkQMZHhu7D+oeGKt8L4feGUKdLzeQKtbaEqQoVDfS72lsjy6M5Ez3d0PCGUGNLGHqpcyNdFlpZTPS046pa9QWtTQO21z6SoDHfA1rAF/LntuL4q2iCsxHm7NxxapZNWBxSzq2pY2pS9dU5J1gknYGZZV1+7KLqNXpsQVznXCFF04WPwjGnwfdCsf/Sd1vbZcptEB/VzlDWJfKsJ5p9apSHAXhtJZEWlDRgsRLU3iMhsGF4zm1V49BTnSGZWweckx8BFJy2VOZVkurXhxPXVH/eCNRO5F+KTh+qge2IeMd4aMOpE1efTl8btOfhtz2wZhOkPst7IDAP2NBxBEKMnQrRtnYqZ1ZfsyV0z5EVgcFhZs/9FWAU6orBDxmUqzgQx/yZzidttDdeUl37t+kPFA0zanEs/GOAYz5DRo0p61gG9B6XCOeXJNdhekKcfCZ+Z7YApuQ1eJmV9Vl/YJioaS+DRmEYw3Y0ei6pA4EIgK3o0562oSHYKGi6hHWTdHecCDrOhUf9sPe4c+gJqcqDqkB8teSgt6+1raUx/lruv+hzIsswbALwQgO+Yvk5I8yPa7Cf7R6j4ihkccG8KEGFztBtYiAiJBri96Aa6orao4BVpdUDpFt0zw+PiTfbekKsDAeWT/oy8ot2SsHCna9wxBrKZBTQPbtEAj81JkA0xl39nFt27RBs922rC/iBX5fROLiiXrJ9MzdXhqPH+N0Qs12vH5Kl/ez1ZLbuclv8yxZLKh7nj7MJym2eYoz6lSnycL21H1jmX7drWJ6lySLa+oOR9wHXi2SLBLxYrF6SEQ8mYgsXfxKfex0uaCXEZ5Hk9WY2u59iz6d3mYYSR6S6TIS83iJvyeDi1W6jG/SSbp8jkSyHF37VrrjevIsxuliNIlT6oKDsBuPOlkwd7GMl6vlLHv+ULCQP6+bSfoA2vQ6+oFCbsVDko3u8bJjsx+YJOLPq5hGadltupySom/xHEPcbJmOVpM4E/NVNp+RkujFtOPymbvs6XLCNxvT2fRqqJsZ34ss+5uLS7d+Psv42oCuTpLZLd/xjGZZloywCqdxu5pE4mZ1d3VL9wLEGf+9FY9phtf2YMXDarEEl2CYbc2rOckEtoZ5TZNHPPM1Q7pYZunNapkE9zaZGCdZ+ggFPtqhBSw8BaDuK9UcT/yrADRWBbUU+f32yPa+QyhHXqz3JYFSkEn5zmDXjLTJCKeJL1T/2XSGncVEfJuJPyWqW9uA3BOEUF/ONlWUbYsbmmRbhAfCLiMu+/RGAy/ryjbFCG04zWmaWlfyaP7nP/5TbCW1I+C/bdl07TwOTqVtHLhC9BRYfUf7y6Rr5xHKTRxv0FTyG9/auDuq5Dd2kyz58yrN7PXa8B6NbBnWInA8mPeUwimCK6iZvd+br24m6YKu1m6wKOW1IECnidMlI5okdzGvJL+5dZa1mCejNJ6wuwBwYON4prsqcINf/Gq+mqZ86OylCdwwxg7j+CG+g/vEmb18Iw87uW3yvL27AnT3hU8p+QiJRfdbP5LpHnB3k2BePH7EorHfDl62SK2bdhdojjG6/UcAQ5Fi2xun18be5D7KEmx927gtuB9RI/ZQrKXs8VDbemKtuR51JTg1X1x+8y5wirTrbJuutU2R4G1X22LR5m9g4qQlZKztEYH3fe2IGliUUUZ9Rc67QTilfeVoekmKvnXGUU99wBaKPmow4h/fP3DEVOFdBmVzfvtrX48a8XMk/j4S/xiJP0binyLxz5H4+e9Y2z//bDlEmvKqXvtM0B3RuUwj5ToMSiZ/y8NiMygyXQHuyhTbLFPVltZIuotwX0EMgITSI0q5KAN5PZlvO9hukbY1vK+abe+Rbxq8IfHZ+OubbtcwTwASmqH9kGwnzQ9bxZ9rgZyUEPT1xd/WMw974l/50oNOknuXvuBjLga9fUpg9Ks0vbPYjgAXZKfXqIWibH/QDrFJJCvENPUhKA7DGtMWMaJBLvRLZ5+daXdVjtWz9PdancEzi0SCBCp0/jZU2eXANvp0P2+6eztORpXpr02x2Rqa8LjwSbn4NXKAMqj12G3gT1UrOz/CgW1cBQdd4fzbykbD3j/7ZhMfBzXOfFy0WS+V4uSirv3F95963xdyfRjtWnqRk4CtX+lNu6dz3/BNHiGPOVAFQOaydfG47wYynNBCH1+PJA2tkZsu5fUZOGy88XfGIfotB3xRi4xaEOe/POLeR9UdchPcHQ85W0vmqZS+9xf0Ko7CQbQN79ih1kcn3dHnDAHZ8P7TN2X6Gzle9CJRLVFhQpIrrlCqjaJ63+YP3LH5S0sQigFPwt8HDsXyZWN5XkHn3W7DTue+Uup10nebXQe096ZOFFu5fvnygJpDlmVeybo176KiVe3af+7Xtwu5NnJHXdabAdbsZF5QnU9XLcMOGfnUYIC6bOEdbzTY/HTjgyb9HqDLQ5nbzaEXUvgpJRcs+OwJPcyZgGJvc1/zUnEfqa1kxc7ImnPeMbgpjejKvze23PorEeVNyA84YLpdrGf45gNHz+DriR90mfwRbVtt72uthTjNe2c/6TO4TwZ6abuj05IaUrLrQgBW1L7dIwvmOAkDBN7Q9yOuVX26kdWQ7TF1CnIfFNrMRv9AyR0bhZTExFvOKQ1tB3d36ZJrbVoeHQAyFzxbd75UNf1+cB/qjHImQCCgXgLztA7PmC1sV9+q9YNdr0/tnsaR97SN8zhyYe06ZHv7SYb9tDA8ESbgYTAM+N33ggTQqmLf1vxlKemATc1HXapQPBHjLpnCnsHHRDjuEQ7xHW9AyfvaACbXNcjyZ1P0wWxhUwtyLH+QZzvvNlfa79vKf1/rM9GTT36DVnh37Rx2tvctpyu+td3rdYgXrud6/X8=", false, false),
            new PieceOfInformation(@"35_1099014494_2012376479", null, @"Assetto Corsa Shared Memory Library", @"AssettoCorsaSharedMemory", @"https://github.com/mdjarv/assettocorsasharedmemory", @"XVJLbtswEN3zFAOvEkBIP4suuqMlOiYqiQIlx/VSlmiLgSwaIh0j9+ktuuiiB+oVOiM7SVPAgMGZeb8Z/fn5K5MVpLYxgzeMxe74PNp9F+CmuYXPHz99gawOna09JI+/f4xPjBVmPFjvrRvAeujMaLbPsB/rIZg2gt1oDLgdNF097k0EwUE9PMPRjB4BbhtqO9hhDzU0KMVwEtk9eLcL53o0ONxC7b1rbI180LrmdDBDqAPp7WxvPNyEzsCsvCJmt5NIa+qe2QGo99KCsw2dOwUYjQ+jbYgjAjs0/aklDy/t3h7sVYHgU37PkPTkMQH5jODgWrujfzPFOp62vfVdBK0l6u0pYNFTcVpkRDk+uBG86XuGDBZ9T1nf3E0zZP1ICw3XFXmqnDt3eJ/EerY7jQNKmgnTOlzZpPhomkAVGt+5vndnita4obWUyH9lrMJWvXVPZspyOe/gAlq9WKADHN+uem35ru572JrrwlAX11v/E2ckeR/w8Lbu4ejGSe//mHeovxRQqkW15lqALKHQ6kEmIoEZL/E9i2Atq6VaVYATmufVBtQCeL6BbzJPIhDfCy3KEpRmMitSKbAm8zhdJTK/hznicoXfsMQvGUkrBSR4pZKiJLJM6HiJTz6Xqaw2EVvIKifOhdLAoeC6kvEq5RqKlS5UKVA+Qdpc5guNKiITeXWHqlgD8YAPKJc8TUmK8RW61+QPYlVstLxfVrBUaSKwOBfojM9TcZHCUHHKZRZBwjN+LyaUQhbNaOziDtZLQSXS4/iLK6lyihGrvNL4jDClrl6ha1mKCLiWJS1koVUWMVonItREgrhcXFho1fDuIjhC71UpXgkhETxFrpLAFPFl+O4v", false, false),
            new PieceOfInformation(@"10_-841269115_1406199749", null, @"AvalonEdit", null, @"https://github.com/icsharpcode/AvalonEdit", @"XVLNjtowEL77KUacdqVoe+/NJAasBjtyzFKOITHEVYhR7BTts/XQR+ordOxlf1oJCc145vub/Pn1W/cGtlxDaVszegMPWDwSUpnpYr23bgTroTeTOb7AeWrGYLoMTpMx4E7Q9s10NhkEB834AlczeVxwx9DY0Y5naEjrri9xMvQI490p3JrJ4HAHjfeutQ3iQefa+WLG0ITId7KD8fAQekMW9X1j8ZhIOtMMYEdEM/D2BDcbejcHmIwPk20jRoZD7TB3qIG8PQ/2Yu8McX2y5z74CDp7dBB1ZnBxnT3Ff5NsXefjYH2fkc5G6OMcsOljM2WVRR9f3ATeDENEsKg7ef1Ql2aQhVxjoOEeUeK99e7yrxOM6DRPI1KaLtl1GFli/GHaEFHi+MkNg7vFeFs3djY68l8JiYdsju6nSV6SPRhdQKmvEuIBrh9XvT/5vkHtR3MPzHQE420+2ZkivQ94eIvZX92U+P63+YT8Gwa1XOk9VQx4DZWSz7xgBSxojfUigz3XG7nTgBOKCn0AuQIqDvCNiyID9r1SrK6JVMC3VckZ9rjIy13BxRqWuCckfqYcv08E1RIi4R2KsxrByJapfIMlXfKS60MGK64FYsIKQSlUVGme70qqoNqpStYM6QuEFVysFLKwLRP6iXCBPWDPWEC9oWWZqOgO1SvkUZDL6qD4eqNhI8uCYXPJUBldluyVShxIXlK+zaCgW7pmaUsiikpjd3X7DUst5KP4yzWXImaSS6EVlhnRUun31T2vWQZU8ToGslIS4WOcuCETCO4J9ooSo46qyftFcCS62NXsQ0vBaIlYdVz+fL6nvw==", false, false),
            new PieceOfInformation(@"11_63558086_-472086088", null, @"CachedImage", null, @"https://github.com/floydpink/CachedImage", @"XVLNjpswEL7zFKOcdiW0/VFPvTngLFYJRoZsmqMDTnBFcIRNo322HvpIfYXOkOxut1KkaMYz39/w59fvujOwFjXktjGDN3CHxX0UJe78PNpjF+CuuYfPHz99gUyPttUeSt10009jgu2jqDTjyXpv3QDWQ2dGs3+G46iHYNoYDqMx4A7QdHo8mhiCAz08w9mMHhfcPmg72OEIGhrki3AydAjj3SFc9GhwuAXtvWusRjxoXTOdzBB0IL6D7Y2Hu4AGFtVtY3E/k7RG95EdgN5enuBiQ+emAKPxYbQNYcRgh6afWtLw8tzbk70x0Pocgo8QdPLogHTGcHKtPdC/mW2dp31vfRdDawl6PwVsemrOmcbk44MbwZu+jxDBou7Z65u6eYaknynQcIvIU+fSudN7J9ZHh2kckNLMO63DyGbGH6YJ1KHxg+t7dyFrjRtaS4781yiig+u9+2lmL9cbDy6g1KsEOsD57aq3J9/pvoe9uQWGvBiv/sfOSPQ+4OGt7uHsxpnvf5sPyJ9xqOSq3jLFQVRQKvkkUp7CglVYL2LYijqTmxpwQrGi3oFcASt28E0UaQz8e6l4VYFUkViXueDYE0WSb1JRPMIS9wqJn7PA7xhBawlEeIMSvCKwNVdJhiVbilzUuzhaibogzJVUwKBkqhbJJmcKyo0qZcWRPkXYQhQrhSx8zYv6AVmxB/wJC6gyludEFbENqlekDxJZ7pR4zGrIZJ5ybC45KmPLnF+p0FSSM7GOIWVr9sjnLYkoKqKxqzrYZpxaxMfwl9RCFmQjkUWtsIzRpapfV7ei4jEwJSoKZKXkOo4oTtyQMwjuFfyKQlHDu4vgCNWbir8CQspZjlgVLZPFl+GHvw==", false, false),
            new PieceOfInformation(@"8_-1576396159_-1557838949", null, @"EmojiOne", null, @"https://github.com/Ranks/emojione", @"lZDNTsMwEITveYqRuKHQcODUW1Wh/qh/IhX3jbO0Bse27E2rPhsHHolXwGkqoR4Qqi+WPDPfeuf78+suHTw37l2vLWMU5OjCR5bdAyPvjeYIcSBjsFlNQLZG+TrBmzZJoIgjJyXdZE+gmryQaGcjGqp50EEWWrGNPMQ4cNIOjLFrms4yEgm6ajs/ngaPmFnhYM95Ml102jZk8cKJWxn+Je1F/LAo1AWoet7AhV1hek8sqlORmEWHSfO8YUkA3pHBlkMTb4KYLqdczVmWXbe1cvbhj8Zkz5jTgaIK2kuOeble5dhMNznGZZljul0u+hrzc6t84HCSvbY7sIkM6wTKpUeu0dqaw5lI/TBcvgiqkuW65+Vs++/Wzieva4Pi64VT9gc=", false, false),
            new PieceOfInformation(@"9_-865240484_-1001197761", null, @"ExifWorks", @"ExifWorks", @"https://www.codeproject.com/Articles/4956/The-ExifWorks-class", @"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", false, false),
            new PieceOfInformation(@"23_-656282555_1649727296", null, @"Modern UI for WPF (MUI)", @"FirstFloor.ModernUI", @"https://github.com/firstfloorsoftware/mui", @"1VZNj9s2EL37Vwx8iReQFaT5BWlSFAU2wSLZHnocS5TNLkUKJLVe/bYe8pPyF/qGlCxZXhTIsTeLHzPz3pt59I9/vn/WlXfBNZEe+oPRFd3rStmgaPc57B/u7zabx5MOZMbVo3tW3gbq8ds1FE+KuKpc27EdtD2SRDqzVyX90dDg+nRQTk0bRVrFHdVFbMyhLzdqR9bF+YiaThTT1jpmudm8K+mTarTVUTsbpGgcUb4NtPWq867uK1Vs5w85Jt+18vqZo35WdHb+KWCNbY11HaLXh17ObenEz2NGbhW1iq1gPSkP9ODCIgr9WX4rqXLd4PXxFMnwGWV9oG3l7CIS8Eoch0PaslnQ4jwyD8R1nTHIQnVie1S44tZ4l4GdT3Hldqd8cBaHOdIFAgLoGGhZyFjzFf+bzXbUvqaOo7IxgAyBSItUb8K4SZVh3YacyyuukdCrKpqBEH+dENF/Kel3z7iIvvkqHEGm3Yc7+njhLG3v6Vt/+BuBJtRZxtRsc7UFaVuZvhYdFi0iOSf+REejWx05f2tLQSXh6X1BiqvTEhcdJXnI3Ykus3v1ggQBnVFIa5j6rGv89G5gE4d945Vayj3mR82XfrshoaAOm0Lpuu0E3u1pQTCreCvi2DI3wZIkAqSCLlGU3f16Rw9Ztv8dyVPW3LJCglm1qYBo+QkX06C2LDF6qT8oYzBaTYObDfIHNoKq7ZyPid+3WHTA5s8aKUB257Kz3ZCt7dUMCvmvqShn/usexHhfouevGLyfGcwz8cXRoweMlv3T5Mh7unLi2mGuxQ0Tp4nS1IqJDXFIaY0F9+ENWbhXQcYdXbKbOGUIY4eMBnzwIjhfzTnxkbUNcR2V5D2Ydbg0Xr4DmrRtJBzEOgy3D8F09YKq8a6l0K/aZuV/pGwN4rDVgrSKjRkEwccLgsXQJFeE2mlemleeorYP4l8R8AiR5pkuxtqKmag8khxndSEAKh+RS2mY8CCAbmXfffrJ+tIwgaNKOqpW0sDtWDMP8hYGB6uF396auZA9z64YeNsZFbNjrceczjqeshrLZ6/8+WoljTbQWhoj+8srlaeac/m5cp7tU2hMxWqQmupavVG73+7o8Srtwg+2HPY6lFv6S9pYsU8Veh2epFr4DMjQsUwBlqNBR5lh60i9iH7IzF6mCkUUdOxZfiuVn+TL5JYpiwBKrjM93CwtZEPfAtg4kBllItg4tKv8OUCOk66u4VHFViY6P/soM7e9ekkjgrcdLhEB89V4xbX1CKpkrnX+56ITp/UCmVCCIiVZ5IM2Og4FNTpaIUDMUhwAUle9AZFd75M1ygCIcU9z3aK08l8=", false, false),
            new PieceOfInformation(@"18_1668019067_971726590", null, @"NVIDIA FXAA Shader", @"FXAA", @"https://gist.github.com/bkaradzic/6011431", @"tVLNbuM2EL7rKea2m0Lwboue2hMt0TYBWXRJKq5vq0j0hoAlBhKdIM/WQx+pr9CPtANnu0VvPdimOcPvb+avP/4s/NPr5L4+BvrY3dFPn3/8Oaf6XpSCUSHVTipmhKwXxE4nSn0zTXa207PtF1mmbO/mMLmHc3B+pHbs6TxbciPN/jx1Nt08uLGdXunop2HO6cWFR/JT+vXnkA2+d0fXtREgp3ay9GSnwYVge3qa/LPrcQiPbcCXBcjp5F/c+JU6P/YuPpqz+Giw4ZeMfqBvFc3kj29SOt+j7TwHGAgtJEa89sE/x9I1hIyIRh9cZ3OU3UwngEWMG1uy9K0UMHan1g12WvybBFC9i+BNArz1Z8j6H1TQxVyE6X13HuwY2rf5fEL0HsWJhjbYybWn+RZzmk1EfW8geaqtS49icWwHG9V8vyZQfWtJ2bswRxkQfsHz0wziV3qwcVFgwZMde9zauBMQMvhg6ZINVq2HQmxahDiidklj9sfwEmd+XSGan2wXdwjvXNysKW7PeNmjeU4WMrMRmrRcmT1TnHDeKQn9vKTlgcyGw8buoMR6Y2gjq5IrTV++MI3ODx+I1SU+h4z/vlNca5KKxHZXCbwGnGK1EVznJOqiakpRr3NaNoZqaagSW2HQZmQeWbLvn5Fc0ZarYoO/bCkqYQ6JbyVMHblWIGO0Y8qIoqmYynYN8tacoo9S6KJiYsvLBYEelMTveW1Ib1hV/cOX3NdcQXtWyNooAYkSLpccItmy4hem+gBQxQsT7dxOBaKCvionveOFwAFhcJhh6pDHPICp+W8NmlCkkm3ZGt4+/nckGYZQNIpvo2TkoJulNsI0htNayjIFrbm6FwXXv1IldUqr0TwHg2GROEIgKpTRu2y0SKGJ2nClml1cyjsMdI9UoJHhaZnSxa5GqwhIqkMG0JhBCj+n/YbjXsU8U1IsRqCRWGHet4EPAZrs5pFqvq7EmtcFj1UZUfZC8zvMSujYIC60e3Yg2STLcURQlaXjuxXN0yBJrIiV9yLKvjZj9lpc9yRFVmyucS/+Bg==", false, false),
            new PieceOfInformation(@"8_-1979742796_-1365526933", null, @"Json.NET", null, @"http://www.newtonsoft.com/json", @"VVLNbtswDL77KYicWsDril0G7KbYSqPVkQxZaZajYyuxBscKLGVBn22HPdJeYaSbri0QICBFfn/0399/TGdhJQwUrrFDsHCDxW2SZP70PLpDF+GmuYUv9/df4Xt9tAGkvUQ/fHp0wyFJSjseXQjOD+ACdHa0u2c4jPUQbZvCfrQW/B6arh4PNoXooR6e4WTHgAt+F2s3IAzU0CAbTiaxQ5jg9/FSjxaHW6hD8I2rEQ9a35yPdoh1JL6961HNTUT5s+q6MbudSFpb9+CGhN5en+DiYufPEUYb4ugawkhxqOnPLWl4fe7d0V0ZaH2KICBocg7ogHSmcPSt29O/nWydzrvehS6F1hH07hyxGag5JZqSj89+hGD7nhAc6p68vqmbZkj6iQKN14iIFy6dP8IHJxjR/jwOSGmnndZjZGmCjD9tE6lD43vf9/5C1ho/tI4chW9JQueud/6Xnby8XHjwEaW+SKADnN6uen0KXY3ad/YaGPK6AbCVvNoZyXCIeHiH2Z/8OPHR8d9Lv0P+JYdKLcyGaQ6iglKrJ5HzHGaswnqWwkaYpVobwAnNpNmCWgCTW3gUMk+B/yg1rypQOhGrshAce0JmxToX8gHmuCcVfswCv2IENQqI8AoleEVgK66zJZZsLgphtikshJGImSyUBgYl00Zk64JpKNe6VBVH+hxhpZALjSx8xaW5Q1bsAX/CAqolK4qJiq1RvZ70ZarcavGwNLBURc6xOeeojM0LDhMVmsoKJlYp5GzFHkidBoUoehq7qtssObUS5GP4y4xQkmxkShqNZYoutfm/uhEVT4FpUVEgC60QnuLEDRwREmVJyV9QKGr4cBEcoXpd8TctOWcFYlXk+P3w3T8=", false, false),
            new PieceOfInformation(@"7_-4385210_598346215", null, @"LevelDB", null, @"https://github.com/google/leveldb", @"pVLLbtswELzzKxY9NYXgPo7tiZZom4AsqiQV10dFomMCkhiIdIJ8Ww/9pP5Cl4zTuA+gh15sisudnZmd71+/5e7ucba3xwCvuyv48O79e9BHA6W5N0OxBHoKRzf7BdBhgPTOw2y8me9NvyBEmt76MNubU7Bugnbq4eQN2Am8O82dSTc3dmrnRzi4efQZPNhwBDenf3cKZHS9PdiujQAZtLOBOzOPNgTTw93s7m2Ph3BsA/4YBBkG92CnW+jc1NvY5GMTGU34SAgAvIFfSXlwh2c2nesNjCcfUENokWWEbG/cfSydfSCTC7YzGdashwGRIsDltKn/jQqO64bWjmZe/J0BTrow4ZkBqutPyOonCfKTBPwPCXIW1rvuNJoptM+7eYu2O6zMMLbBzLYd/IvFaS9YJJfUz3oqY1NbRJ3a0UQya+duBwN86hbI9qWW/LbBo5jpCQfzgwMf4cbEcCBvB2bq8dbEHCCB0QUDT25gvHpkhumCAxZI0u/dITzEZJwzA/7OdDE02GRjlOYYl+kpON4n3kRvuAIlVnpHJQM811Jc84IVsNyD3jDIRb2XfL3RsBFlwaQCWhV4W2nJl40WUpFXVGHnq1Sg1R7Yl1oypUBI4Nu65AiG6JJWmjOVAa/ysil4tc4AAaASmpR8yzU+0yJLQ/9sA7GCLZP5Bj/pkpdc79O8FddVnLUSklCoqdQ8b0oqoW5kLRSDKKvgKi8p37JigdNxIrBrVmlQG1qWv6okYlcxGalfSoQlg5LTZcnioCSy4JLlOqp5OeVoHNIrM6JqlnM8oBcMtVC5z86Yin1u8BEWoaBbukZpr//hCK4kbyTbRspog2qWSnPdaAZrIYrks2LymudMfYJSqGRWo1hGCqppGowQ6BSW8bxsFE+e8UozKZtac1Fd4Xp36ApypNhaJHNFFaViRpiQ+wgaPUjeZ7DbMLyX0c/kFI0WKHQs15fPcB4aqMmLRqjYuuRrVuUsVkVE2XHFrnBVXMUHPI3F5ePMJkmOK0JWJB0vApulRQJfAS2ueaR9foyrV/wck2RZvjnbvfgB", false, false),
            new PieceOfInformation(@"28_-1260613915_-1720553161", null, @"LevelDB for Windows and .NET", @"LevelDB.net", @"https://github.com/Reactive-Extensions/LevelDB", @"ZZFBbttADEX3PsWHVw3gyomX7UpxXFRoIgOW0yDL8YiSCcgzE86ois+WRY7UK5RyXCBBVgTBD/L9z78vr0sfjsLtPmFxebXAHVvx0TcJSy/Bi0ns3WRyy5ZcpBq9q0mQ9oQ8GKvlPJnhN0lULRbZJb6Mgul5NL34jqPvcTBHOJ/QR9IFHNFwR6BnSyGBHaw/hI6Ns4SB0/505Lwiw+N5gd8lo1qj6qBd814Fk7BPKXybz4dhyMwJMPPSzrs3QZzfFstVWa2+KuRkcu86ihFCTz2LetsdYYIiWLNTsM4M8ALTCuks+RFxEE7s2hnGhAYjhJpjEt716UM2/4HU5HuBpmMcpnmFopriOq+KaoaHYvtzfb/FQ77Z5OW2WFVYb7BclzfFtliX2v1AXj7iV1HezECajB6h5yAjuwLymBrVGSqiD8cb/wYTA1lu2Koj1/amJbT+D4lTIwgkB47j36Ki1ej4wOn08/jZTvYP", false, false),
            new PieceOfInformation(@"17_-1842149017_137208794", null, @"C# LZF Compressor", @"LZF", @"http://csharplzfcompression.codeplex.com/", @"nVXRbts2FH3XV1xswNoAjpd2GDCsxVBZYmwOsuRJVNLsqbREx8Qk0aPkZt6v7WGftF/YIWUnbpHuYQ+2aZE895zDy6N//vqbtztrPqqaPirba9PRYCj6mhK9Tn69ppWxw49BZHYHq++3A72sLuj11asryk0rOwoHWW217Iae3v6mGt3V0r67b6VuppVpfwqCDNt0JxuKvox29T1lVnX085SWcm91peitObTj8N1W/mmsklNj76e6OYc8UsSPlfZA31DY3Burh237TI2rS3z9gAK2wjr1h+xqZSlRW8jo6G1fbVtjd++Ov9NaoVKuat0PVq/3gzMGW2jfK9Id9WZvQdM9WYMLqm+MbfsJPaA8Get/zX6g1tR6oyt5GTiICUmraKdsq4cBljvndY3BsJUDvhRgmsY86O6eKtPV2m3q/aZWwbng1ZToU1Y9mc2JTmVqLNz3A1k1SNB0iHKN08XUyY/ODLB1Egxb3VMDJAdwXqyrP2OCclUjdavsNAheP8MAlc5cODGAuHoPVs+QCI4k6P+QoFFYUJtq36pukKfD+Ra+G8xYauWgrJZN/+SwPxgHeU4der6DHoHHnWyVI+HZ7nF4DuXg3KK1csdeu4uhutpYtABmgdyaQdEoc+gD9JN292iDiVFYbzbDgzu8Uzf0O1W5dsAm7ZrEujboxobo+5GQWPCCiuxa3IY5I4xXeXbDYxbT7I7EglFYikWW04cPYYHpFy8oTGN87oi9X+WsKAiTfLlKOIsDYORhKjgrJsTTKCljns4nNCsFpZmghC+5ALLIJh76uI2etlF2TUuWXwbRAg/CGU+4uPMVr7lIXbVrlAtpFeaCR2US5rQq81VWgCfox7yIkpAvWQybeYqiAbthqaBiESbJuZwZA5twlrAREHJinrNION5PowhGgEYyoWLFQIq7IXvPwDvM7yZOepSlBfulxDJMUhwuwzlkvPxv9QFMjsqcLR03SC7KWSG4KAWjeZbF3tOC5Tc8YsUbSrLCG1MWbIIKIvSFAQFPijeBU1MW3LvDU8HyvFwJnqUXtMhuIR8cQ2yNvY1Z6sXCiSy/c6DOBe/yJLhdMDzPnXFQJfLQmVCInEfibJmrLbJcnGmklM0TPmdpxNxsJhaXActvecEucCy8cEv4WPg2RNXSi3anAV7j8KwJ4TDOjPg1hfENMOLguBjHXPBjS3jTosXRcPRx2OAOdricH1VzmPh7hQuOdh/68Z7hgmx0o/w1O12xvU9ltxabW7cwcH/maUlz1SmL1F/t1w1uUIL86HATT2+t1/TSrfxqvkq+upi4jHjY6mpLlex9BAU+CfpTYnrUVeKjVe52QJTrxkV7PyhZPwaBi60p8Q0dzB63uEeEmEC6TPLz7m1g/KR9JPKJNtM1h2dEeUK+PHLORQyiZUT1+dW7/w77y8CPmMGsiJGg3gwnu4aS4bizRtr4resDxo0aXJA6HmdejMkMHgESu5FjXrdPcTkmtSc6ZuvZXqt+32uLYwP+0VBnVuDMqo0X5suqZ4viZQiESu80esJ3weeSg2ckK+1ZOECn3NjHyv8C", false, false),
            new PieceOfInformation(@"8_140457287_", null, @"Meta.Vlc", null, @"https://github.com/higankanshi/Meta.Vlc", null, false, false),
            new PieceOfInformation(@"9_2141631627_-1536644098", null, @"MoonSharp", null, @"http://www.moonsharp.org/", @"lZTBcts2EIbvfIqdnOIOLbWZtof0BJGQhClFKgRoR0eKhCR0SEIDgNY4nT5ZD3mkvkIXkBzLcSadXiQKwOL//2+X+ufvz4k+Phq1Pzh429zAux9/+vkWP36NYVWbRuOndUYfa93piHQdhKMWjLTSPMh2EkXr2uCC3oE7SMDDathDp7amNo9QGwnb2soW9BD2f9dHlY01HI3+QzaoeXDuaN9Pp3vlDuN20uh+muOB6eXgTfTK3zvIdJpE0Z2yY90Bd2OrNCS6ldDK7bjfSwON/6Xss3ZY2Bndw0o1Rlu9c/Bg/eptrwd9Gyq/6+pL3fRV3c3kK5fPGok2R21qp9DDLVLrZHA0Di26XDGBpBo5WIkcS9lrJyF9yqAaPdhAMPj29GjTqaOVr32eTqeJPG9OtNlPXzjC1oir4rlG9eAoivz6SuuBH2pzDIqemo/AbF038Zd5+MX7a5Vv73YMaeoBY+B1agCrR9PIsLJVg+/7TpvexnBCfKBN+Naji3rdqp1qgngcoh2l6ZVziAQzPagWH9yhdiHtTnedPvlxQl+t8kVnHr1076PoB3jpKMzgxUpodz9ah8hdrc6zV2/1g9964jJoh/Bj3FM2AuyEDayuxYb2Kyco2HS16qWZfMsBKl0ReHKA0doRXX3HBOp7G//XBFyitboZezm4c1vB10yRu8Y9A33tpFF1Z58Zh8aEwiv7IVEuVSjym0Pdy6cX+08cq3pQn4LCX2j7+UgAr5xniLbP12ljUfcRttIPCQbQIIcWV6WfB/QRZv0MBv898G1Q+G8SJv0JhX9/Tr7dl+kBe5SNHx8sU36ojB+c4TxC1p4DiCXjwIu5uCclBXxel8UdS2kKsw2IJYWkWG9KtlgKWBZZSksOJE9xNRclm1WiwIU3hGPlm8hvkHwD9OO6pJxDUQJbrTOGl+HtJckFozwGlidZlbJ8EQNeAHkhIGP4auMxUcReNHpdBsUcVrRMlviTzFjGxCYYmTORe605ihFYk1KwpMpICeuqXBecAsaKUsaTjLAVTSeojopA72gugC9Jln0zpff+IuOMokkyy2gUlDBlykqaCB/n+SlBcugvi4GvacL8A/1IMQwpN/HlTk4/VHgIN6OUrMgCs739DyTYk6Qq6cp7Rg68mnHBRCUoLIoi9aAjTss7llD+G2QFD7QqTmNIiSBBGK9AVLiNz7OKswCN5YKWZbUWrMhvMPk9YimjhGBpGugWeYiKhIpy4y/1DAL8GO6XFNdLDzSQIh4BR2KJuDoWoR4CFFcZIaeLjC1onlDvpvC33DNOb7BXjPsD7Cx7T1CzCpF9j9BVFB6vJjYOnQQ2B5LeMW/7chh7z9llTgKyZAln3JN/AQ==", false, false),
            new PieceOfInformation(@"7_-1868496878_655939918", null, @"OxyPlot", null, @"http://www.oxyplot.org/", @"XVLNjtowEL77KUacdqVo+6OeevMmZrEa4sgxSzmGxBBXIUa2KeXZeugj9RU6NuxuWwkJzXjm+5v8/vlLDRqWXEFpOj15DXdY3BOS2+PFmf0Q4K67h4/vP3wC8eNSjzZAZ6fgzPYUrPOE1NodjPfGTmA8DNrp7QX2rp2C7jPYOa3B7qAbWrfXGQQL7XSBo3YeF+w2tGYy0x5a0iFhnAwDwni7C+fWaRzuofXedqZFPOhtdzroKbQh8u3MqD3chUGTWXPbmN0nkl63I5gJ0TS8PMHZhMGeAjjt0UAXMTIc6sZTjxrIy/NoDubGENdTCj6Cnjw6iDozONje7OK/TraOp+1o/JCR3vhrNtj0sZlCzaKPd9aB1+MYEQzqTl7f1KUZZCHHGGi4RZR4z4M9/OsEI9qd3ISUuk92LUaWGL/pLkSUOL6z42jPMV48WW+iI/+ZkHjxdmu/6+TleuTJBpR6lRAPcHy76u3JDy1q3+pbYLonGG/7lx0X6X3AwxvM/mhd4vvf5gPyLxg0Yq7WVDLgDdRSPPOCFTCjDdazDNZcLcRKAU5IWqkNiDnQagNfeFVkwL7WkjUNERL4si45wx6v8nJV8OoJHnGvEvg9c/yQEVQJiIQ3KM4aBCNLJvMFlvSRl1xtMphzVSEmzBGUQk2l4vmqpBLqlaxFw5C+QNiKV3OJLGzJKvVAeIU9YM9YQLOgZZmo6ArVS+SRkIt6I/nTQsFClAXD5iNDZfSxZFeqakPykvJlBgVd0ieWtgSiyDR2U7desNRCPoq/XHFRxUxyUSmJZUaUkOp1dc0blgGVvImBzKVA+BgnbogEgnsVu6LEqKNq8noRHIkuVg1701IwWiJWE5f/Pt/DHw==", false, false),
            new PieceOfInformation(@"13_1265365092_-1200296128", null, @"SharpCompress", null, @"https://github.com/adamhathcock/sharpcompress", @"nVjbbttIEn3XV1QyD7EXCmU78TgJsAhkiYq5I0uCKMebDQaYFtmSOibZHDZpRfNr+7CftL+wp6opX8aehw0QhGqyuy6nTl3a//33f36ieKOqcmDzstLOdTqPlmQcKUralbEFZWZZqWpHK1tRMAkXvUtb2F5ssltdZWa9qXvXszOqN6qmRBXUFNjdxePsD1Pys33UqsL/S6xOSBUpfq/xm7am3rDorarS17bIdlRplZpiLZtWJtNU4ZfNSSUJ29efRS6g68rUmlxTlraqxTQI60FHTzT0RLaqNJm8zHSui1qnQaez2GjK1TdsX2lVN/zdPZJS2OK10/pGLaHY1bAlxwZLmarWWsxx4uVSU1lZNkinBJBqCF7B+AMT6IBSuy0yq9JWwmFAnc7XF1/PG5PxO2h2vx5s6rp0H3q9xASqLG/1zlYBcO+p0vQg+5tOatfzm3u39vv6/dmx1Xl++31zrHsISZFserlyta4+utv13+uq0Yd/LbWV2FOpyhGqTWKTm57jyO9j/VjmYafz00800XDvQmflx87Mupoi5xogAIc/IW7N8kWnM9jo5Eb8/xp7IHFkZKtc1XByNJ1f9hdxkKeHEtCv58qZhK6cWuvg14OruP8p5I+irU+xhIvm+neoqTudC0MaNNvZAqhGtLGlpp1tXiFwjWOSPOaup0wh9DE1tuhVkwU0y7RymtbmFtFHnODUUsFouLFl2rLEFDy/0VRbQvgp2ahiDT+0K3ViVIbIKkcrUBiPxqmlyUy9o7XV4OJEb+/o5Jr1GpYjb5zQT2VbtXO01Rlg1nwaPzP2ZWsbkEFlTK5W801ht96iffzpSW4uNTvXMO1MwXLkMGzm1xuch9/G+Q0QuffZpJodYOI3YihQ5eyG+Qv4euMQyRam1CILatK5MhkfTU0FU4AAxCl3I0I2oERAFK0YOwTfFEIBn0+KUzjDL3ClS6WXWmnJMVjH2wKJ97Uqapaa2KKuzLKp9cdOJ3qV71HLrL1ht/YaCU9x5C6krlnmEJnYVPNHb7OUlHbfVYHDdVOoWme7Ln1rQOJM1zWLhW+C+OPwiyJ4IRgUtllvgHmiACjAZseAxEYB1cKSBYp4AR9REuzKx64AvRxLWjKWQtxX2JNqMNOwGVLJytZq8UAKraevSlPBVDGOuc6XumLJnF8tKV4IdovpcOro4A6p2iGH/kbz/pxO9xUN67N/cY1FsYTDWGL181s8L5usNq9vbdYABN7Sngi8iHsJrOqzpwqN7ZrX9y+OguO3wTGr/cqNgfqohvkyM1q4X7yquf5ZIF2oXKf3tWkttcMXu78uR8If1zs+fXfIGmY3W04oXSTVruQEE1qw7b4qpyZljQgHQsqfcvaRqwk3FMcgIkhoBNXuRy15fyaWfGKlIQtCCJHErHbp1dwrrU2u3Q8renf4DNJHgnT8oFuN2ZJ9vzQekYWq/m+9ZZNl0Hr8VOubNr4j852KhqmunNvaSpreHJp1NVJJbatdQHd7bOkLILbEKN8FrOxXyQal6McMe+cZcKmQobMyT2cV+kBVM88y9YcvTLfW8ExRaO7JPK4wERIlhgQ/qPb0OTwkCucAXUqTbxQf6NysEYiVQMFUm95DgIEl2Gdim1aOhnqVoSY9kX8SvGX5Iz8QkQxEPMoIM8D07/RjjPr5CFIXlWDFUlYVUhJxvEGqrhWos2Qylzv2qeZZBzauKkxd/4inE07uZyx909m7BYmIxQ9ZdvaGy5HaLblXZlzjfDpvDVZsoC/nbe0LvjloR9F+xpwTNmefHTMvh05O33sHnzlw/PDAg3mWTp/ZLGGXKjewKEPzxeUL5kGz9nD6xEMdBn4lHHZPRBwHP3f+dGKd2SUa5UbSiPMXIrBFZtuKO9DWdxqFloXntNQF/ba0NvtNOg9PmGjCmGl3QIqrUJJZdz+2mhU3sdeVH6ZkHgieMev0oVkwIr5BRHNdb2z6zG6h55OphE3VmLtQYQvd1GiKdIABUNxgT/nKwF2yxiJ3nM2jFoOokESgA26bMgxIRt3P7ZLC7QntpXGTS3UNPuDTMzZKYPtpCoEDjLQ64zSMfLXiBqdzwJf6aCKydxcA7r9jU/x+XpkUJqQagKdoOLunOgQzjXhwIBCgneZLDw8y4JrDHcNw5vq8kDy6m3Fs5V4Q4TgGamf4mrH8czFpi2VYYEKQyu7oajF6xzmKKUKhxTDgXFQWQOKuprRt3pOQW65rh2R+kWFEa+cD5AZjh7leeKcYqCceHvn0HplCJh72JKWhcaV1+9kO4w4ASGC9qFUI/RaNX2z3WctTS+sMl8FnlJx02simNEf+tCbtWxoH2xS3KkNt199rjkYqnbXNGccYXGPgt1uMyjUnpvIzyG7PyocTCDb/gneFN995G8f8mXPXI+bnay48crHDkasyVT576HN8cnT8RmJX1XJF3NfKeHwq9NkbM9tg8qN3dNCUPv7x+K3fMDt72lWOPGU9DlJR4W2lhN+EVsdZw0TmMgit+VMBH+4p//A6y+Ee6ruJ6aCWWV/G3KfFelMptzMp51qIudML41vLuW2QBAPcC+GxCEOaZoy0iPIj159UtWBw7+qH8cMvKDF38D2EzMdvOB47qUcGLDc8Y/hJ/yDy1wyAF7NNfCntgY9JI8PzhzuHHnWZgGdsFJLv4mB6tx3lWWB+XGVoqfx1/l4anw/W1q4z7a/RuB4XuLumr7M/ctXrdMbRIJzEYWeA5llJ9zhIDunk6OiIXuNxfMz1mcZ6zfKnK1l5PKkFVGYTqNput8FSviTyIbDVGt7OdNVeEJjSfHlCGVjjqg5OdsEt3FYxb6B0gIhdCUexY85wo7RLLkc+Obm7+5sE/8nDrmoZp+XK4ZzFJZc5ntqkuYfDd+IDzuKXcXvi5aEoSeWG5//usf8k+WSbGumLrDPC3i42JVkj2bz/nBnc2bwGPi6oCZFwx+qKnV3KUflW/NTiVtngWuE2XUz5rr0qdvnqlJlEF3wKfvTAd4fLNUvg0bC9Ne2tkz2spWRA6xYi0bvdIEEfeQKIVk1VQKVPfNyJnRWNPIXwG/mDj2XmS+W2aH4y8X3wf2RSSzQG8cWTAo0YpnoTOADlfVTbT+AtbMcY5AGT+72MRHt3KlbvagTeAHtOcT9hPnaT/8h1EVI8HS2u+/OQophm8+nnaBgO6WU/xvpll66jxcX0akHYMe9PFl9oOqL+5Av9Ek2GXQr/OZuHcUzTOUWXs3EU4l00GYyvhtHkE53j3GS6oHF0GS0gdDElVtiKipDrEHYZzgcXWPbPo3G0+NKlUbSYsMwRhPZp1p8vosHVmJvR1Xw2jUOoH0LsJJqM5tASXoaTBS7OE7yj8DMWFF/0x2NR1b+C9XOxbzCdfZlHny4WdDEdD0O8PA9hWf98HHpVcGow7keXXRr2L/ufQjk1hZS5bGutu74I5RX09fFvsIimE3ZjMJ0s5lh24eV8cXf0OorDLvXnUcyAjOZTiGc4cWIqQnBuEnopDDU9igi28PoqDu9tGYb9MWTFfPjh5uB/", false, false),
            new PieceOfInformation(@"6_-1919219596_107757880", null, @"SlimDX", null, @"https://slimdx.org/", @"XVHNbtswDL77KYicWsDr2l4G7KbYSiLMsQxZaZujYyuxBscKLHlBn22HPdJeYaSTtugAA4ZIfn/k399/End6HeyhDXBT38Lj/f23L4/3Dw9QdvaYvsBycOMpigozHK331vVgPbRmMLtXOAxVH0wTw34wBtwe6rYaDiaG4KDqX+FkBo8AtwuV7W1/gApqVItwMrRI490+nKvB4HADlfeuthXyQePq8Wj6UAXS29vOeLgJrYFZeUXMbieRxlRdZHug3lsLzja0bgwwGB8GWxNHDLavu7EhD29tjGevCgSfVuAjJB09JiCfMRxdY/f0N1Os07jrrG9jaCxR78aARU/F2vSEwhxf3QDedF2EDBZ9T1k/3E0zZP1ECw3XFXmqnFt3/JzE+mg/Dj1KmgnTOFzZpPjT1IEqNL53XefOFK12fWMpkf8eRRpb1c79MlOWy4V7F9DqxQId4PRx1WvLt1XXwc5cF4a6to+o9BZnIHkf8PC26uDkhknv/5h3qL/iUMqFfmaKgyihUPJJpDyFGSvxPYvhWeiV3GjACcVyvQW5AJZv4YfI0xj4S6F4WYJUkVgXmeBYE3mSbVKRL2GOuFxqyMRaaCTVEkjwSiV4SWRrrpIVPtlcZEJv42ghdE6cC6mAQcGUFskmYwqKjSpkyVE+Rdpc5AuFKnzNc32HqlgD/oQPKFcsy0gqYht0r8gfJLLYKrFcaVjJLOVYnHN0xuYZv0hhqCRjYh1DytZsySeURBYV0djFHTyvOJVIj+GXaCFzipHIXCt8xphS6Xfosyh5DEyJkhayUHIdR7RORMiJBHE5v7DQquHTRXCE3puSvxNCylmGXHie/NP57v4B", false, false),
            new PieceOfInformation(@"27_1767902742_167133862", null, @"SlimDX DirectX 11 Tutorials", @"SlimDX.dx11", @"https://github.com/ericrrichards/dx11", @"VVFLbtswEN3rFAOvUkBIf7vuaImOicqUQNFxvZQl2mIhiwZJ18jZuuiReoXOKEqTABaMGb55n5m/v/9k7vLk7amPcNd+gC+fPn8F423r8esb34UkqYw/2xCsG8EG6I03hyc4+WaMpkvh6I0BdwRCn0wK0UEzPsHF+IAD7hAbO9rxBA20qITIJPZIE9wx3hpvENxBE4JrbYN80Ln2ejZjbCLpHe1gAtzF3sCinicWHyaRzjQD2DGht5cnuNnYu2sEb0LEAMSRIqgdrh15eHke7NnOCjQ+xQ9ImlwDJiCfKZxdZ4/0b6ZYl+thsKFPobNEfbhGbAZqtmakKczx0XkIZhiIwaLvKeuruwlD1i+00DiviHTh1rszvEuCKzpe/YiSZprpHK4sTVDxp2kjdQh+dMPgbhStdWNnKVH4liQan5qD+2WmLM/XHV1Eq88W6ACX16vOT6Fv0PvBzAtDXTsCtpKXOJ4Ch4iHt7j7i/OTHh3/rfV71F9zqMuV3jHFQdRQqfJR5DyHBauxXqSwE3pdbjUgQjGp91CugMk9fBcyT4H/qBSvayhVIjZVITj2hMyKbS7kAyxxTpYaCrERGkl1CSQ4UwleE9mGq2yNJVuKQuh9CiuhJXImq1IBg4opLbJtwRRUW1WVNUf5HGmlkCuFKnzDpb5HVewBf8QC6jUrikmKbdG9mvxlZbVX4mGtYV0WOcfmkqMztiw4TFIYKiuY2KSQsw17IHcKSmRRE2x2t1tzaiWox/CXaVFKipGVUissU0yp9P/Rnah5CkyJmhayUiXS0zpxAiFCoi0p+TMLrRreXQQhVG9r/uol56xArpoSvwXf/wM=", false, false),
            new PieceOfInformation(@"15_1746373167_-1305869619", null, @"Modern UI Icons", @"WindowsIcons", @"https://github.com/Templarian/WindowsIcons", @"jVXBbhs3EL3vV0zhQyXBXgXoLSc7dmM4cVSjslu0QVBQ3JHELJfcklxt5V/LIZ/UX+gbrmTLhQ4+aUkOZ948znv699v3E7o1ml3korizrCKTVoGXnbVb6lzFISblKkprJjsEkqwr3zvr1e5AJY6JjPYukkr0yeOee7i5kY1S+6YsipMTenhO94fvAv1qVusUi5mni5SCWXTJeJezY+uKg9lwRb/7UMdinVL7djrVgVXCNlI2ktqH1XSHKk4X2zNXTX8q30xpUhRndLOkrZRpg//KGvAi+ZYdRWxqJuO07SpGAzjYt7Y0Vk5yV0NciUwzjyC3kgyOuQKqXcgyeJdoqbSc7uuMHma3P8/nUrwgApnURTlXbkt+me8NTFkTE3It2Pp+n1EdMBGRDb9jgXCJjjlooyyycUbiE3mHV1IW9yVPl4idBmq14qqU/k3uWrlcEGCOFBEQA4RTQUwxGWtzm5T8U6TQ5CP/ACRXPpeucO/piFE4GXTaKl2jOo1uftzwE7JMceUfQTEYAI5kGo609OHFi+wIjKdDK40ylhp5EwzNeBihSxkAHwDjogNSRxeuCtxHGp0nblqrglFuPITiaTJAHyYTXPigtvSn6oNPeIfROZb71RiIkJDedU6vEflLAKaZ0utGuXyk2nahQqnXvMGDlzL7x/a79tiu5WU6th9k+jPSl6MOJJb/oTs0mgznm3MvD/+Wdiro+75UiGmHEBHYdM/d9Ct4gUDQ9V95yqa5xIHAJpmNjwFP8psSRTY+JTQ8Oq83B+vxIeaGK6OVLdvOwihkGp3oWB7go9HQRqyF03r//eKy7gII1dsydAvL8ejRCgw4hcyfVIym8TRXG/X4aJC0icPnkPNWxhUqakzMogILPoiKcrNIcBe85VR3NtF1UO3a1Kci04buMaUz3zmJEKoOcVRB9aVM4gjwWwxyNZY5sGZjONB1Z9xrkzQq1CzzeW0WAcJ7Z6Lxr7286HTNqRhmmt57kAOHCK+4vgQXHNpgHEZqkkP3lmYGoR1oftBXFuXORwL/3UnXZTGZYBw3sIMWVj04PUezcrJKa7WTJfi+f5LbgVlSOUTvDA4GsoALVINjYiWRO4so6W52jQo2wmW05haPOABrINSkanTgpanDLIJvQvlvhbLDaN8aJEcObeFPcEPxsB6j+X/34iZ3I3aca+b/tgzo8nLPFTxGXEOB27O92J5tJesMB6pqjPt8/uX55HP5BWdC/JXngVG8C8AAAxBus9QB0/qVlxmd19tWZPReaV54X+PzvjdQnQwOJ12W5X8=", false, false),
            new PieceOfInformation(@"24_154463160_", null, @"Hardcodet WPF NotifyIcon", @"WpfNotifyIcon", @"http://www.hardcodet.net/wpf-notifyicon", null, false, false),
        }.Where(x => !x.IsHidden).ToArray();
    }
}
