// Este ejemplo le guiará por los elementos del lenguaje F#.  
//
// *******************************************************************************************************
//   Para ejecutar el código en F# Interactive, resalte una sección de código y presione Alt-Entrar, o haga clic con el botón secundario 
//   y seleccione "Ejecutar en modo interactivo".  Puede abrir la ventana de F# Interactive desde el menú "Ver". 
// *******************************************************************************************************
//
// Para obtener más información acerca de F#, vea:
//     http://fsharp.net
//
// Para obtener plantillas adicionales para su uso con F#, consulte 'Plantillas en línea' en Visual Studio, 
//     "Nuevo proyecto" --> "Plantillas en línea"
//
// Para consultar temas específicos de F#, vea:
//     http://go.microsoft.com/fwlink/?LinkID=234174 (Portal de desarrollo de Visual F#)
//     http://go.microsoft.com/fwlink/?LinkID=124614 (Galería de código)
//     http://go.microsoft.com/fwlink/?LinkId=235173 (Programación de matemáticas o estadísticas)
//     http://go.microsoft.com/fwlink/?LinkId=235176 (Gráficos)

// Contenido:
//    - Funciones básicas y con enteros
//    - Booleanos
//    - Cadenas
//    - Tuplas
//    - Listas y procesamiento de listas
//    - Clases
//    - Clases genéricas
//    - Implementación de interfaces
//    - Matrices
//    - Secuencias
//    - Funciones recursivas
//    - Tipos de registros
//    - Tipos de uniones
//    - Tipos de opciones            
//    - Detección de patrones        
//    - Unidades de medida        
//    - Programación de matrices en paralelo
//    - Uso de eventos
//    - Acceso a bases de datos mediante proveedores de tipo
//    - Acceso a OData mediante proveedores de tipo



// ---------------------------------------------------------------
//         Funciones básicas y con enteros
// ---------------------------------------------------------------

module Integers = 
    let sampleInteger = 176

    /// Realizar algunas operaciones aritméticas empezando con el primer entero
    let sampleInteger2 = (sampleInteger/4 + 5 - 7) * 4

    /// Lista de los números del 0 al 99
    let sampleNumbers = [ 0 .. 99 ]

    /// Lista de todas las tuplas que contienen todos los números del 0 al 99 y sus cuadrados
    let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, i*i) ]

    // La línea siguiente imprime una lista que incluye tuplas, usando %A para impresión genérica.
    printfn "The table of squares from 0 to 99 is:\n%A" sampleTableOfSquares


module BasicFunctions = 

    // Usar 'let' para definir una función que acepte un argumento de entero y devuelva un entero. 
    let func1 x = x*x + 3             

    // Los paréntesis son opcionales para los argumentos de la función
    let func1a (x) = x*x + 3             

    /// Aplicar la función, asignando un nombre al resultado devuelto por la función mediante 'let'. 
    /// El tipo de variable se infiere del tipo de valor devuelto por la función.
    let result1 = func1 4573
    printfn "The result of squaring the integer 4573 and adding 3 is %d" result1

    // Si es necesario, anotar el tipo de un nombre de parámetro mediante '(argument:type)'
    let func2 (x:int) = 2*x*x - x/5 + 3

    let result2 = func2 (7 + 4)
    printfn "The result of applying the 1st sample function to (7 + 4) is %d" result2

    let func3 x = 
        if x < 100.0 then 
            2.0*x*x - x/5.0 + 3.0
        else 
            2.0*x*x + x/5.0 - 37.0

    let result3 = func3 (6.5 + 4.5)
    printfn "The result of applying the 2nd sample function to (6.5 + 4.5) is %f" result3



// ---------------------------------------------------------------
//         Booleanos
// ---------------------------------------------------------------

module SomeBooleanValues = 

    let boolean1 = true
    let boolean2 = false

    let boolean3 = not boolean1 && (boolean2 || false)

    printfn "The expression 'not boolean1 && (boolean2 || false)' is %A" boolean3



// ---------------------------------------------------------------
//         Cadenas
// ---------------------------------------------------------------

module StringManipulation = 

    let string1 = "Hello"
    let string2  = "world"

    /// Usar @ para crear un literal de cadena textual
    let string3 = @"c:\Program Files\"

    /// Mediante un literal de cadena de comillas triples
    let string4 = """He said "hello world" after you did"""

    let helloWorld = string1 + " " + string2 // concatenar las dos cadenas con un espacio en medio
    printfn "%s" helloWorld

    /// Cadena que se forma tomando los primeros 7 caracteres de una de las cadenas de resultados
    let substring = helloWorld.[0..6]
    printfn "%s" substring



// ---------------------------------------------------------------
//         Tuplas (conjuntos de valores ordenados)
// ---------------------------------------------------------------

module Tuples = 

    /// Una tupla de enteros sencilla
    let tuple1 = (1, 2, 3)

    /// Una función que intercambia el orden de dos valores en una tupla. 
    /// InformaciónRápida muestra que se infiere que la función tiene un tipo genérico.
    let swapElems (a, b) = (b, a)

    printfn "The result of swapping (1, 2) is %A" (swapElems (1,2))

    /// Una tupla formada por un entero, una cadena y un número de punto flotante de doble precisión
    let tuple2 = (1, "fred", 3.1415)

    printfn "tuple1: %A    tuple2: %A" tuple1 tuple2
    


// ---------------------------------------------------------------
//         Listas y procesamiento de listas
// ---------------------------------------------------------------

module Lists = 

    let list1 = [ ]            /// una lista vacía

    let list2 = [ 1; 2; 3 ]    /// lista de tres elementos

    let list3 = 42 :: list2    /// una nueva lista con '42' agregado al principio

    let numberList = [ 1 .. 1000 ]  /// lista de enteros del 1 al 1.000

    /// Una lista que contiene todos los días del año
    let daysList = 
        [ for month in 1 .. 12 do
              for day in 1 .. System.DateTime.DaysInMonth(2012, month) do 
                  yield System.DateTime(2012, month, day) ]

    /// Una lista que contiene las tuplas que son las coordenadas de los cuadrados negros de un tablero de ajedrez.
    let blackSquares = 
        [ for i in 0 .. 7 do
              for j in 0 .. 7 do 
                  if (i+j) % 2 = 1 then 
                      yield (i, j) ]

    /// Elevar al cuadrado los números de numberList mediante el operador de canalización para pasar un argumento a List.map    
    let squares = 
        numberList 
        |> List.map (fun x -> x*x) 

    /// Calcula la suma de los cuadrados de los números divisibles por 3.
    let sumOfSquaresUpTo n = 
        numberList
        |> List.filter (fun x -> x % 3 = 0)
        |> List.sumBy (fun x -> x * x)



// ---------------------------------------------------------------
//         Clases
// ---------------------------------------------------------------

module DefiningClasses = 

    /// El constructor de la clase toma dos argumentos: dx y dy, ambos de tipo 'float'. 
    type Vector2D(dx : float, dy : float) = 
        /// Longitud del vector, calculada cuando se construye el objeto.
        let length = sqrt (dx*dx + dy*dy)

        // 'this' especifica un nombre para el propio identificador del objeto.
        // En los métodos de instancia, debe aparecer delante del nombre del miembro.
        member this.DX = dx  

        member this.DY = dy

        member this.Length = length

        member this.Scale(k) = Vector2D(k * this.DX, k * this.DY)
    
    /// Una instancia de la clase Vector2D
    let vector1 = Vector2D(3.0, 4.0)

    /// Obtener un nuevo objeto de vector a escala sin modificar el objeto original 
    let vector2 = vector1.Scale(10.0)

    printfn "Length of vector1: %f      Length of vector2: %f" vector1.Length vector2.Length



// ---------------------------------------------------------------
//         Clases genéricas
// ---------------------------------------------------------------

module DefiningGenericClasses = 

    type StateTracker<'T>(initialElement: 'T) = // 'T es el parámetro de tipo de la clase

        /// Almacenar los estados en una matriz
        let mutable states = [ initialElement ]

        /// Agregar un nuevo elemento a la lista de estados
        member this.UpdateState newState = 
            states <- newState :: states  // usar el operador '<-' para transformar el valor

        /// Obtener la lista completa de estados históricos
        member this.History = states

        /// Obtener el último estado
        member this.Current = states.Head

    /// Una instancia 'int' de la clase del rastreador de estados. Observe que se ha inferido el parámetro de tipo.
    let tracker = StateTracker 10

    // Agregar un estado
    tracker.UpdateState 17



// ---------------------------------------------------------------
//         Implementación de interfaces
// ---------------------------------------------------------------

/// Tipo que implementa IDisposable
type ReadFile() =

    let file = new System.IO.StreamReader("readme.txt")

    member this.ReadLine() = file.ReadLine()

    // la implementación de esta clase de los miembros de IDisposable
    interface System.IDisposable with    
        member this.Dispose() = file.Close()



// ---------------------------------------------------------------
//         Matrices
// ---------------------------------------------------------------

module Arrays = 

    /// La matriz vacía
    let array1 = [| |]

    let array2 = [| "hello"; "world"; "and"; "hello"; "world"; "again" |]

    let array3 = [| 1 .. 1000 |]

    /// Una matriz que contiene solamente las palabras "hello" y "world"
    let array4 = [| for word in array2 do
                        if word.Contains("l") then 
                            yield word |]

    /// Una matriz inicializada a través de un índice que contiene los números pares del 0 al 2.000
    let evenNumbers = Array.init 1001 (fun n -> n * 2) 

    /// submatriz extraída mediante la notación divisoria
    let evenNumbersSlice = evenNumbers.[0..500]

    for word in array4 do 
        printfn "word: %s" word

    // modificar un elemento de matriz mediante el operador de asignación de flecha izquierda
    array2.[1] <- "WORLD!"

    /// Calcula la suma de las longitudes de las palabras que empiezan por 'h'
    let sumOfLengthsOfWords = 
        array2
        |> Array.filter (fun x -> x.StartsWith "h")
        |> Array.sumBy (fun x -> x.Length)



// ---------------------------------------------------------------
//         Secuencias
// ---------------------------------------------------------------

module Sequences = 
    // Las secuencias se evalúan previa petición y se vuelven a evaluar cada vez que se recorren en iteración. 
    // Una secuencia de F# es una instancia de System.Collections.Generic.IEnumerable<'T>,
    // por lo que también se pueden aplicar funciones Seq a las listas y matrices.

    /// La secuencia vacía
    let seq1 = Seq.empty

    let seq2 = seq { yield "hello"; yield "world"; yield "and"; yield "hello"; yield "world"; yield "again" }

    let numbersSeq = seq { 1 .. 1000 }

    /// otra matriz que solo contiene las palabras "hello" y "world"
    let seq3 = 
        seq { for word in seq2 do
                  if word.Contains("l") then 
                      yield word }

    let evenNumbers = Seq.init 1001 (fun n -> n * 2) 

    let rnd = System.Random()

    /// Una secuencia infinita que es un recorrido aleatorio
    //  Usar yield! para devolver cada elemento de una subsecuencia, similar a IEnumerable.SelectMany.
    let rec randomWalk x =
        seq { yield x
              yield! randomWalk (x + rnd.NextDouble() - 0.5) }

    let first100ValuesOfRandomWalk = 
        randomWalk 5.0 
        |> Seq.truncate 100
        |> Seq.toList



// ---------------------------------------------------------------
//         Funciones recursivas
// ---------------------------------------------------------------

module RecursiveFunctions  = 
              
    /// Calcular el factorial de un entero. Usar 'let rec' para definir una función recursiva
    let rec factorial n = 
        if n = 0 then 1 else n * factorial (n-1)

    /// Calcula el factor común mayor de dos enteros. 
    //  Como todas las llamadas recursivas son llamadas de cola, el compilador convertirá la función en un bucle,
    //  lo que mejora el rendimiento y reduce el consumo de memoria.
    let rec greatestCommonFactor a b =                       
        if a = 0 then b
        elif a < b then greatestCommonFactor a (b - a)           
        else greatestCommonFactor (a - b) b

    /// Calcula la suma de una lista de enteros mediante recursividad.
    let rec sumList xs =
        match xs with
        | []    -> 0
        | y::ys -> y + sumList ys

    /// Convertir la función en recursiva de cola utilizando una función auxiliar con un acumulador de resultados
    let rec private sumListTailRecHelper accumulator xs =
        match xs with
        | []    -> accumulator
        | y::ys -> sumListTailRecHelper (accumulator+y) ys

    let sumListTailRecursive xs = sumListTailRecHelper 0 xs



// ---------------------------------------------------------------
//         Tipos de registros
// ---------------------------------------------------------------

module RecordTypes = 

    // definir un tipo de registro
    type ContactCard = 
        { Name     : string;
          Phone    : string;
          Verified : bool }
              
    let contact1 = { Name = "Alf" ; Phone = "(206) 555-0157" ; Verified = false }

    // crear un nuevo registro que sea una copia de contact1, 
    // pero con valores diferentes para los campos 'Phone' y 'Verified'
    let contact2 = { contact1 with Phone = "(206) 555-0112"; Verified = true }

    /// Convierte un objeto 'ContactCard' en una cadena
    let showCard c = 
        c.Name + " Phone: " + c.Phone + (if not c.Verified then " (unverified)" else "")
        


// ---------------------------------------------------------------
//         Tipos de uniones
// ---------------------------------------------------------------

module UnionTypes = 

    /// Representa el palo de una carta
    type Suit = 
        | Hearts 
        | Clubs 
        | Diamonds 
        | Spades

    /// Representa el rango de una carta
    type Rank = 
        /// Representa el rango de cartas 2 .. 10
        | Value of int
        | Ace
        | King
        | Queen
        | Jack
        static member GetAllRanks() = 
            [ yield Ace
              for i in 2 .. 10 do yield Value i
              yield Jack
              yield Queen
              yield King ]
                                   
    type Card =  { Suit: Suit; Rank: Rank }
              
    /// Devuelve una lista que representa todas las cartas de la baraja
    let fullDeck = 
        [ for suit in [ Hearts; Diamonds; Clubs; Spades] do
              for rank in Rank.GetAllRanks() do 
                  yield { Suit=suit; Rank=rank } ]

    /// Convierte un objeto 'Card' en una cadena
    let showCard c = 
        let rankString = 
            match c.Rank with 
            | Ace -> "Ace"
            | King -> "King"
            | Queen -> "Queen"
            | Jack -> "Jack"
            | Value n -> string n
        let suitString = 
            match c.Suit with 
            | Clubs -> "clubs"
            | Diamonds -> "diamonds"
            | Spades -> "spades"
            | Hearts -> "hearts"
        rankString  + " of " + suitString

    let printAllCards() = 
        for card in fullDeck do 
            printfn "%s" (showCard card)



// ---------------------------------------------------------------
//         Tipos de opciones
// ---------------------------------------------------------------

module OptionTypes = 
    /// Los valores de opción son cualquier tipo de valor etiquetado como 'Some' o 'None'.
    /// Se usan de forma exhaustiva en el código de F# para representar los casos en los que muchos otros
    /// lenguajes usarían referencias NULL.

    type Customer = { zipCode : decimal option }

    /// Clase abstracta que calcula la zona de envío del código postal del cliente, 
    /// especificando implementaciones para los métodos abstractos 'getState' y 'getShippingZone'.
    [<AbstractClass>]
    type ShippingCalculator =
        abstract getState : decimal -> string option
        abstract getShippingZone : string -> int

        /// Devolver la zona de envío correspondiente al código postal del cliente
        /// El cliente puede que no tenga aún un código postal o que el código postal no sea válido
        member this.customerShippingZone(customer : Customer) =
            customer.zipCode |> Option.bind this.getState |> Option.map this.getShippingZone



// ---------------------------------------------------------------
//         Detección de patrones
// ---------------------------------------------------------------

module PatternMatching = 

    /// Un registro para el nombre y los apellidos de una persona
    type Person = {     
        First : string
        Last  : string
    }

    /// definir una unión discriminada de tres tipos diferentes de empleados
    type Employee = 
        | Engineer  of Person
        | Manager   of Person * list<Employee>            // el director tiene una lista de jefes
        | Executive of Person * list<Employee> * Employee // el director ejecutivo tiene también un ayudante

    /// contar todas las personas situadas bajo el empleado en la jerarquía de directivos, incluido el empleado
    let rec countReports(emp : Employee) = 
        1 + match emp with
            | Engineer(id) -> 
                0
            | Manager(id, reports) -> 
                reports |> List.sumBy countReports 
            | Executive(id, reports, assistant) ->
                (reports |> List.sumBy countReports) + countReports assistant


    /// buscar a todos los directores o ejecutivos llamados "Dave" que no tengan jefes
    let rec findDaveWithOpenPosition(emps : Employee list) =
        emps 
        |> List.filter(function 
                       | Manager({First = "Dave"}, []) -> true       // [] coincide con la lista vacía
                       | Executive({First = "Dave"}, [], _) -> true
                       | _ -> false)                                 // '_' es un comodín que coincide con cualquier cosa
                                                                     // esto controla el caso "or else"



// ---------------------------------------------------------------
//         Unidades de medida
// ---------------------------------------------------------------

module UnitsOfMeasure = 

    // El código se puede anotar con unidades de medida cuando se usa la aritmética de F# en tipos numéricos

    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

    [<Measure>]
    type mile =
        /// Factor de conversión de millas a metros; el metro se define en SI.UnitNames
        static member asMeter = 1600.<meter/mile>

    let d  = 50.<mile>          // Distancia expresada en unidades británicas
    let d2 = d * mile.asMeter   // La misma distancia expresada con el sistema métrico

    printfn "%A = %A" d d2
    // error de let = d + d2       // Error de compilación: las unidades de medida no coinciden



// ---------------------------------------------------------------
//         Programación de matrices en paralelo
// ---------------------------------------------------------------

module ParallelArrayProgramming = 
              
    let oneBigArray = [| 0 .. 100000 |]
    
    // realizar algunos cálculos con gran consumo de CPU 
    let rec computeSomeFunction x = 
        if x <= 2 then 1 
        else computeSomeFunction (x - 1) + computeSomeFunction (x - 2)
       
    // Realizar una asignación en paralelo en una matriz de entrada grande
    let computeResults() = oneBigArray |> Array.Parallel.map (fun x -> computeSomeFunction (x % 20))

    printfn "Parallel computation results: %A" (computeResults())



// ---------------------------------------------------------------
//         Uso de eventos
// ---------------------------------------------------------------

module Events = 

    open System

    // crear una instancia del objeto Event que conste de un punto de suscripción (event.Publish) y un desencadenador de eventos (event.Trigger)
    let simpleEvent = new Event<int>() 

    // agregar un controlador
    simpleEvent.Publish.Add(
        fun x -> printfn "this is handler was added with Publish.Add: %d" x)

    // desencadenar el evento
    simpleEvent.Trigger(5)

    // crear una instancia de Event que siga la convención estándar de .NET: (sender, EventArgs)
    let eventForDelegateType = new Event<EventHandler, EventArgs>()    

    // agregar un controlador
    eventForDelegateType.Publish.AddHandler(
        EventHandler(fun _ _ -> printfn "this is handler was added with Publish.AddHandler"))

    // desencadenar el evento (observe que el argumento sender debe estar establecido)
    eventForDelegateType.Trigger(null, EventArgs.Empty)



// ---------------------------------------------------------------
//         Acceso a bases de datos mediante proveedores de tipo
// ---------------------------------------------------------------

module DatabaseAccess = 
              
    // La forma más sencilla de acceder a una base de datos SQL desde F# es usar proveedores de tipo F#. 
    // Agregar referencias a System.Data, System.Data.Linq y FSharp.Data.TypeProviders.dll.
    // Puede usar el Explorador de servidores para compilar el objeto ConnectionString. 

    (*
    #r "System.Data"
    #r "System.Data.Linq"
    #r "FSharp.Data.TypeProviders"

    open Microsoft.FSharp.Data.TypeProviders
    
    type SqlConnection = SqlDataConnection<ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=tempdb;Integrated Security=True">
    let db = SqlConnection.GetDataContext()

    let table = 
        query { for r in db.Table do
                select r }
    *)


    // También puede usar SqlEntityConnection en lugar de SqlDataConnection, que obtiene acceso a la base de datos con Entity Framework.

    ()



// ---------------------------------------------------------------
//         Acceso a OData mediante proveedores de tipo
// ---------------------------------------------------------------

module OData = 

    (*
    open System.Data.Services.Client
    open Microsoft.FSharp.Data.TypeProviders

    // Use el servicio OData de datos demográficos y de renta de Azure Marketplace. 
    // Para obtener más información, consulte http://go.microsoft.com/fwlink/?LinkId=239712
    type Demographics = Microsoft.FSharp.Data.TypeProviders.ODataService<ServiceUri = "https://api.datamarket.azure.com/Esri/KeyUSDemographicsTrial/">
    let ctx = Demographics.GetDataContext()

    // Suscríbase para obtener una cuenta de Azure Marketplace en https://datamarket.azure.com/account/info
    ctx.Credentials <- System.Net.NetworkCredential ("<your liveID>", "<your Azure Marketplace Key>")

    let cities = query {
        for c in ctx.demog1 do
        where (c.StateName = "Washington")
        } 

    for c in cities do
        printfn "%A - %A" c.GeographyId c.PerCapitaIncome2010.Value
    *)

    ()



#if COMPILED
module BoilerPlateForForm = 
    [<System.STAThread>]
    do ()
    do System.Windows.Forms.Application.Run()
#endif
