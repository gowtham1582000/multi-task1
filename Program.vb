Imports System
Imports System.Security.AccessControl

Module hospital
    Sub Main(args As String())
        Console.WriteLine("Getting and Printing Employee Details")
        Dim emp1 As Employee = New Employee()
        emp1.getEmpInfo()
        emp1.showEmpInfo()

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Multiple From Object Of Array Employee Details")
        Dim numEmployees As Integer
        Console.WriteLine("Enter the number of employees:")
        numEmployees = Convert.ToInt32(Console.ReadLine())
        Dim employees(numEmployees - 1) As Employee1
        For i As Integer = 0 To numEmployees - 1
            employees(i) = New Employee1()
            Console.WriteLine("Enter details for Employee " & (i + 1) & ":")
            employees(i).getEmpInfo()
        Next
        Console.WriteLine("---------- Employee Details ---------")
        Console.WriteLine()
        For Each emp As Employee1 In employees
            emp.showEmpInfo()
        Next

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Bank Account Details To Check Is The Account is Eligible For Credit Car")
        Dim bank As Bank = New Bank()
        bank.GetDetails()
        bank.getAccountBalance()

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Bank Account Details with Constructor With And Without Arguments")
        Dim bank1 As BankAccount = New BankAccount()
        Console.WriteLine()
        Dim accNumber, accType As String
        Console.WriteLine("Enter Account Number:")
        accNumber = Console.ReadLine()
        Console.WriteLine("Enter Account Type (Savings Or Current):")
        accType = Console.ReadLine()
        Dim bankAcc2 As New BankAccount(accNumber, accType)
        bankAcc2.getBankDetails()
        Console.WriteLine("Enter amount to deposit:")
        Dim depositAmount As Decimal = Convert.ToDecimal(Console.ReadLine())
        bankAcc2.Deposit(depositAmount)
        Console.WriteLine("Enter amount to withdraw:")
        Dim withdrawAmount As Decimal = Convert.ToDecimal(Console.ReadLine())
        bankAcc2.Withdraw(withdrawAmount)
        Console.WriteLine()
        Console.WriteLine("Bank Account Details:")
        bankAcc2.Display()
        Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Car And Bike Details with the Choose of User")
        Dim audi As Audi = New Audi()
        Dim ford As Ford = New Ford()
        Dim baj As Bajaj = New Bajaj()
        Dim tvs As Tvs = New Tvs()
        Dim car_brand As String
        Dim bike_brand As String
        Console.WriteLine("Which Type Of Car Brand you want Choose Option")
        Console.WriteLine("1.Ford")
        Console.WriteLine("2.Audi")
        car_brand = Console.ReadLine()
        If car_brand = "1" Then
            ford.getOwnerDetails()
            ford.printOwnerDetails()
        Else
            audi.getOwnerDetails()
            audi.printOwnerDetails()
        End If
        Console.WriteLine("Which Type Of Bike Brand you want Choose Option")
        Console.WriteLine("1.Bajaj")
        Console.WriteLine("2.TVS")
        bike_brand = Console.ReadLine()
        If bike_brand = "1" Then
            baj.getOwnerDetails()
            baj.printOwnerDetails()
        Else
            tvs.getOwnerDetails()
            tvs.printOwnerDetails()
        End If

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Phd and Graduate Students With abstract Method")
        Dim phd As New PhdStudent1()
        Dim grad As New GradStudent1()
        phd.TakeExam()
        grad.TakeExam()

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Phd and Graduate Students With abstract Method and Interface Method and Encapsulation")
        Dim ph_name, grad_name As String
        Console.WriteLine("Enter the Phd Student Name : ")
        ph_name = Console.ReadLine()
        Console.WriteLine("Enter the Graduate Student Name : ")
        grad_name = Console.ReadLine()
        Dim phd1 As New PhdStudent(ph_name)
        Dim grad1 As New GradStudent(grad_name)
        phd1.TakeExam()
        grad1.TakeExam()

        Console.WriteLine()
        Console.WriteLine("Getting and Printing Patient Details")
        Dim in_pa1 As New In_patient()
        Dim out_pa1 As New Out_patient()
        Dim pa As New Patient()
        pa.patient_details()
        Dim injury3, patient_type As String
        Dim total_medical_cost As Integer = 0
        Dim total_medical_cost1 As Integer = 0
        Dim patient As New Patient()
        Dim in_pa As New In_patient()
        Dim out_pa As New Out_patient()
        Console.WriteLine("Enter the Option for Patient Type:")
        Console.WriteLine("1. In Patient")
        Console.WriteLine("2. Out Patient")
        patient_type = Console.ReadLine()
        If patient_type = "2" Then
            out_pa1.Out_patient_Details()
            total_medical_cost = out_pa1.medi
            total_medical_cost1 = out_pa1.Consul
            injury3 = pa.GetInjury()
            total_medical_cost += total_medical_cost1
            Console.WriteLine("For the total medical cost for the {0} treatment, you need to pay is {1}", injury3, total_medical_cost)
        Else
            in_pa1.Get_Inpatient_details()
            Console.WriteLine("How many days has the doctor requested you to admit?")
            Dim days As Integer = Convert.ToInt16(Console.ReadLine())
            total_medical_cost = days * (in_pa1.GetDoctor() + in_pa1.GetNurse() + in_pa1.GetRoomCharge())
            Console.WriteLine("The total amount you need to pay for the Doctor of {0} days that you admitted in the hospital is {1}", days, in_pa1.GetDoctor() * days)
            Console.WriteLine("The total amount you need to pay for the Nurse of {0} days that you admitted in the hospital is {1}", days, in_pa1.GetNurse() * days)
            Console.WriteLine("The total amount you need to pay for the {2} Room of {0} days that you admitted in the hospital is {1}", days, in_pa1.GetDoctor() * days, in_pa1.RoomType())
            Console.WriteLine("The total amount you need to pay for the medical care that you admitted in the hospital is {0}", total_medical_cost)
        End If
    End Sub


    Class Employee
        Dim emp_name, emp_degination, emp_city, emp_location As String
        Dim emp_id As Long
        Sub getEmpInfo()
            Console.WriteLine("------- Getting Employee Details ---------")
            Console.WriteLine("Enter the Employee Name:")
            emp_name = Console.ReadLine()
            Console.WriteLine("Enter the Employee Id:")
            emp_id = Console.ReadLine()
            Console.WriteLine("Enter the Employee Desgination:")
            emp_degination = Console.ReadLine()
            Console.WriteLine("Enter the Employee Working Location Name:")
            emp_location = Console.ReadLine()
            Console.WriteLine("Enter the Employee Working City Name:")
            emp_city = Console.ReadLine()
        End Sub
        Sub showEmpInfo()
            Console.WriteLine("------- Employee Details ---------")
            Console.WriteLine("Employee Name : {0}", emp_name)
            Console.WriteLine("Employee ID : {0}", emp_id)
            Console.WriteLine("Employee Desgination : {0}", emp_degination)
            Console.WriteLine("Employee Working Location : {0}", emp_location)
            Console.WriteLine("Employee Working City : {0}", emp_city)
        End Sub
    End Class
    Class Employee1
        Private empID As Integer
        Private empName, emp_location, emp_city As String
        Private empSalary As Decimal

        Public Sub getEmpInfo()
            Console.WriteLine("Enter Employee ID:")
            empID = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Enter Employee Name:")
            empName = Console.ReadLine()

            Console.WriteLine("Enter Employee Salary:")
            empSalary = Convert.ToDecimal(Console.ReadLine())
            Console.WriteLine("Enter Employee Location:")
            emp_location = Convert.ToString(Console.ReadLine())
            Console.WriteLine("Enter Employee City:")
            emp_city = Convert.ToString(Console.ReadLine())
        End Sub

        Public Sub showEmpInfo()
            Console.WriteLine("Employee ID: " & empID)
            Console.WriteLine("Employee Name: " & empName)
            Console.WriteLine("Employee Salary: " & empSalary)
            Console.WriteLine("Employee Location: " & emp_location)
            Console.WriteLine("Employee City: " & emp_city)
            Console.WriteLine()
        End Sub
    End Class
    Class Bank
        Protected Account_name, Account_Type, yes_no As String
        Protected Account_number, Balance As Long
        Sub GetDetails()
            Console.WriteLine("--------- Bank Details ----------")
            Console.WriteLine("Enter The Acount Number : ")
            Account_number = Convert.ToInt64(Console.ReadLine())
            Console.WriteLine("Enter The Acount Name : ")
            Account_name = Convert.ToString(Console.ReadLine())
            Console.WriteLine("Enter The Acount Type (Savings Or Current) : ")
            Account_Type = Convert.ToString(Console.ReadLine())
            Console.WriteLine("Enter How Much Amount Deposited : ")
            Balance = Convert.ToUInt64(Console.ReadLine())
        End Sub
        Sub getAccountBalance()
            Console.WriteLine("Do you want a Credi Card (Y/N):")
            yes_no = Console.ReadLine()
            If yes_no = "NO" Then
                Console.WriteLine("Thank You!!!")
            Else
                If Balance > 800000 Then
                    Console.WriteLine("{0} You have an Eligible for Platinum Cerdit Card", Account_name)
                    Console.WriteLine("Thank You For Claiming Credit Card!!!")

                ElseIf Balance > 500000 Then
                    Console.WriteLine("{0} You have an Eligible for Golden Cerdit Card", Account_name)
                    Console.WriteLine("Thank You For Claiming Credit Card!!!")
                ElseIf Balance > 200000 Then
                    Console.WriteLine("{0} You have an Eligible for Silver Cerdit Card", Account_name)
                    Console.WriteLine("Thank You For Claiming Credit Card!!!")
                Else
                    Console.WriteLine("Sorry {0} you are not eligible to claim Credit Card", Account_name)
                    Console.WriteLine("Thank You")
                End If
            End If
        End Sub
    End Class
    Class BankAccount
        Dim accNumber As String
        Dim accType As String
        Dim accBalance As Decimal

        ' Constructor without arguments
        Public Sub New()
            Console.WriteLine("------- Getting Account Details --------")
        End Sub

        ' Constructor with two arguments
        Public Sub New(number As String, type As String)
            accNumber = number
            accType = type
        End Sub

        Public Sub getBankDetails()
            Console.WriteLine("Enter Account Balance:")
            accBalance = Convert.ToDecimal(Console.ReadLine())
        End Sub

        Public Sub Display()
            Console.WriteLine("Account Number: " & accNumber)
            Console.WriteLine("Account Type: " & accType)
            Console.WriteLine("Account Balance: " & accBalance)
        End Sub

        Public Sub Deposit(amount As Decimal)
            accBalance += amount
            Console.WriteLine("Amount deposited successfully.")
        End Sub

        Public Sub Withdraw(amount As Decimal)
            If amount <= accBalance Then
                accBalance -= amount
                Console.WriteLine("Amount withdrawn successfully.")
            Else
                Console.WriteLine("Insufficient balance.")
            End If
        End Sub
    End Class
    Class Vechile
        Protected mileage, price As Double
    End Class
    Class Car
        Inherits Vechile
        Protected warrenty, seat_capacity As Integer
        Protected owner_cost As Long
        Protected fuel_type As String
    End Class
    Class Bike
        Inherits Vechile
        Protected no_cylinder, no_gears As Integer
        Protected fuel_tank As Double
        Protected cooling_type, wheel_type As String
    End Class
    Class Audi
        Inherits Car
        Protected model_type As String
        Sub getOwnerDetails()
            Console.WriteLine("------ Getting Details Of Audi Car -------")
            Console.WriteLine("Enter Model Type Of Car : ")
            model_type = Console.ReadLine()
            Console.WriteLine("Enter Owner Ship Cost : ")
            owner_cost = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter the Warrenty Of the Audi Car :")
            warrenty = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Seating Capacity of the Audi Car : ")
            seat_capacity = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Mileage Of The Car : ")
            mileage = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter The Price Of the Car : ")
            price = Convert.ToDouble(Console.ReadLine())
        End Sub
        Sub printOwnerDetails()
            Console.WriteLine("------ Full Details Of the Audi Car -------")
            Console.WriteLine("The Model Of the Audi Car {0}", model_type)
            Console.WriteLine("The Owner Ship Cost Of the Audi Car {0}", owner_cost)
            Console.WriteLine("The Warrenty Of the Audi Car {0} Year", warrenty)
            Console.WriteLine("The Seating Capacity Of the Audi Car {0}", seat_capacity)
            Console.WriteLine("The Mileage Of the Audi Car {0}", mileage)
            Console.WriteLine("The Price Of the Audi Car {0}", price)
        End Sub
    End Class
    Class Ford
        Inherits Car
        Protected model_type1 As String
        Sub getOwnerDetails()
            Console.WriteLine("------ Getting Details Of Ford Car -------")
            Console.WriteLine("Enter Model Type Of Car : ")
            model_type1 = Console.ReadLine()
            Console.WriteLine("Enter Owner Ship Cost : ")
            owner_cost = Convert.ToInt64(Console.ReadLine())
            Console.WriteLine("Enter the Warrenty Of the Audi Car :")
            warrenty = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Seating Capacity of the Audi Car : ")
            seat_capacity = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Mileage Of The Car : ")
            mileage = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter The Price Of the Car : ")
            price = Convert.ToDouble(Console.ReadLine())
        End Sub
        Sub printOwnerDetails()
            Console.WriteLine("------ Full Details Of the Ford Car -------")
            Console.WriteLine("The Model Of the Ford Car {0}", model_type1)
            Console.WriteLine("The Owner Ship Cost Of the Ford Car {0}", owner_cost)
            Console.WriteLine("The Warrenty Of the Ford Car {0} Year", warrenty)
            Console.WriteLine("The Seating Capacity Of the Ford Car {0}", seat_capacity)
            Console.WriteLine("The Mileage Of the Ford Car {0}", mileage)
            Console.WriteLine("The Price Of the Ford Car {0}", price)
        End Sub
    End Class
    Class Bajaj
        Inherits Bike
        Protected make_type As String
        Sub getOwnerDetails()
            Console.WriteLine("------- Getting Details Of the Bajaj Bike ---------")
            Console.WriteLine("Enter the Make Type Of the Bajaj Bike : ")
            make_type = Console.ReadLine()
            Console.WriteLine("Enter The Number Of Cylinders in the Bike : ")
            no_cylinder = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Number Of Gears in the Bike : ")
            no_gears = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Fuel Tank Size in Inches : ")
            fuel_tank = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Option Of Cooling Type Of the Bike : ")
            Console.WriteLine("1. Liquid")
            Console.WriteLine("2. Oil")
            Console.WriteLine("3. Air")
            cooling_type = Console.ReadLine()
            Console.WriteLine("Enter The Option Of Wheel Type Of the Bike : ")
            Console.WriteLine("1. Alloys")
            Console.WriteLine("2. Spokes")
            wheel_type = Console.ReadLine()
            Console.WriteLine("Enter The Mileage Of the Bike :")
            mileage = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter The Price Of the Bike :")
            price = Convert.ToDouble(Console.ReadLine())
        End Sub
        Sub printOwnerDetails()
            Console.WriteLine("------- Full Details Of the Bajaj Bike ----------")
            Console.WriteLine("The Make Type Of Bajaj Bike is {0}", make_type)
            Console.WriteLine("The Number Of Cylinders in Bajaj Bike is {0}", no_cylinder)
            Console.WriteLine("The Number Of Gears in Bajaj Bike is {0}", no_gears)
            Console.WriteLine("The Size Of the Fuel Tank is {0}", fuel_tank)
            If cooling_type = "1" Then
                Console.WriteLine("The Cooling Type Of the Bike is Liquid")
            ElseIf cooling_type = "2" Then
                Console.WriteLine("The Cooling Type Of the Bike is Oil")
            Else
                Console.WriteLine("The Cooling Type Of the Bike is Air")
            End If
            If cooling_type = "1" Then
                Console.WriteLine("The Wheel Type Of the Bike is Alloys")
            Else
                Console.WriteLine("The Wheel Type Of the Bike is Spokes")
            End If
            Console.WriteLine("The Mileage Of Bajaj Bike is {0}", mileage)
            Console.WriteLine("The Price Of Bajaj Bike is {0}", price)

        End Sub
    End Class
    Class Tvs
        Inherits Bike
        Protected make_type1 As String
        Sub getOwnerDetails()
            Console.WriteLine("------- Getting Details Of the TVS Bike ---------")
            Console.WriteLine("Enter the Make Type Of the TVS Bike : ")
            make_type1 = Console.ReadLine()
            Console.WriteLine("Enter The Number Of Cylinders in the Bike : ")
            no_cylinder = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Number Of Gears in the Bike : ")
            no_gears = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Fuel Tank Size in Inches : ")
            fuel_tank = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Option Of Cooling Type Of the Bike : ")
            Console.WriteLine("1. Liquid")
            Console.WriteLine("2. Oil")
            Console.WriteLine("3. Air")
            cooling_type = Console.ReadLine()
            Console.WriteLine("Enter The Option Of Wheel Type Of the Bike : ")
            Console.WriteLine("1. Alloys")
            Console.WriteLine("2. Spokes")
            wheel_type = Console.ReadLine()
            Console.WriteLine("Enter The Mileage Of the Bike :")
            mileage = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter The Price Of the Bike :")
            price = Convert.ToDouble(Console.ReadLine())
        End Sub
        Sub printOwnerDetails()
            Console.WriteLine("------- Full Details Of the TVS Bike ----------")
            Console.WriteLine("The Make Type Of TVS Bike is {0}", make_type1)
            Console.WriteLine("The Number Of Cylinders in TVS Bike is {0}", no_cylinder)
            Console.WriteLine("The Number Of Gears in TVS Bike is {0}", no_gears)
            Console.WriteLine("The Size Of the Fuel Tank is {0}", fuel_tank)
            If cooling_type = "1" Then
                Console.WriteLine("The Cooling Type Of the Bike is Liquid")
            ElseIf cooling_type = "2" Then
                Console.WriteLine("The Cooling Type Of the Bike is Oil")
            Else
                Console.WriteLine("The Cooling Type Of the Bike is Air")
            End If
            If cooling_type = "1" Then
                Console.WriteLine("The Wheel Type Of the Bike is Alloys")
            Else
                Console.WriteLine("The Wheel Type Of the Bike is Spokes")
            End If
            Console.WriteLine("The Mileage Of TVS Bike is {0}", mileage)
            Console.WriteLine("The Price Of TVS Bike is {0}", price)

        End Sub
    End Class
    MustInherit Class Student1
        Implements IExamTaker

        Private _name As String
        Public Sub New(name As String)
            _name = name
        End Sub
        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public MustOverride Sub TakeExam() Implements IExamTaker.TakeExam
    End Class
    Class PhdStudent
        Inherits Student1

        Public Sub New(name As String)
            MyBase.New(name)
        End Sub

        Public Overrides Sub TakeExam()
            Console.WriteLine("PhdStudent {0} is giving the final presentation.", Name)
        End Sub
    End Class
    Class GradStudent
        Inherits Student1

        Public Sub New(name As String)
            MyBase.New(name)
        End Sub

        Public Overrides Sub TakeExam()
            Console.WriteLine("GradStudent {0} is writing a paper.", Name)
        End Sub
    End Class
    MustInherit Class Student
        Public MustOverride Sub TakeExam()
    End Class
    Class PhdStudent1
        Inherits Student

        Public Overrides Sub TakeExam()
            Console.WriteLine("PhdStudent is giving the final presentation.")
        End Sub
    End Class
    Class GradStudent1
        Inherits Student

        Public Overrides Sub TakeExam()
            Console.WriteLine("GradStudent is writing a paper.")
        End Sub
    End Class
    Interface IExamTaker
        Sub TakeExam()
    End Interface
    Class Patient
        Private p_name, address, injury As String
        Private mobile, age As Long

        Sub patient_details()
            Console.WriteLine("--------------Enter The Patient Details---------------")
            Console.WriteLine("Enter Your Name:")
            p_name = Console.ReadLine()
            Console.WriteLine("Enter Your Age:")
            age = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter Your Address:")
            address = Console.ReadLine()
            Console.WriteLine("Enter Your Phone Number:")
            mobile = Convert.ToInt64(Console.ReadLine())
            Console.WriteLine("Enter Your Injury Or Sickness Name:")
            injury = Console.ReadLine()
        End Sub

        Public Function GetInjury() As String
            Return injury
        End Function
    End Class
    Class In_patient
        Private Doctor_fees, nurse_fee, room_charge As Double
        Private room_type As String

        Sub Get_Inpatient_details()
            Console.WriteLine("--------------Enter The In Patient Details---------------")
            Console.WriteLine("Enter Doctor Fees Per Day:")
            Doctor_fees = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter Nurse Fee Per Day:")
            nurse_fee = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter The Room Type:")
            Console.WriteLine("1. Separate Room With Or Without AC")
            Console.WriteLine("2. General Ward")
            Console.WriteLine("3. ICU")
            room_type = Console.ReadLine()
            Console.WriteLine("Enter The Room Charges For {0}:", room_type)
            room_charge = Convert.ToDouble(Console.ReadLine())
        End Sub

        Public Function GetDoctor() As Double
            Return Doctor_fees
        End Function
        Public Function RoomType() As String
            Return room_type
        End Function

        Public Function GetNurse() As Double
            Return nurse_fee
        End Function

        Public Function GetRoomCharge() As Double
            Return room_charge
        End Function
    End Class
    Class Out_patient
        Private doctor_consult, medi_cost As Integer

        Sub Out_patient_Details()
            Console.WriteLine("--------------Enter The Out Patient Details---------------")
            Console.WriteLine("Enter Doctor Consultancy Fee:")
            doctor_consult = Convert.ToInt16(Console.ReadLine())
            Console.WriteLine("Enter The Medicine Cost:")
            medi_cost = Convert.ToInt16(Console.ReadLine())
        End Sub

        Public Property Consul As Integer
            Get
                Return doctor_consult
            End Get
            Set
                doctor_consult = Value
            End Set
        End Property


        Public Property medi As Integer
            Get
                Return medi_cost
            End Get
            Set
                medi_cost = Value
            End Set
        End Property
    End Class

End Module
