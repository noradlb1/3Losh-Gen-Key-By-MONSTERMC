﻿Imports System.Security.Cryptography
Imports System.Text
Imports System.Diagnostics

Public Class Form1
    Private Sub RandomizedMethodButtonGenerateClick(sender As Object, e As EventArgs) Handles RandomizedMethodButtonGenerate.Click
        Try
            If String.IsNullOrEmpty(RandomizedTextBoxUserId.Text) Then
                MessageBox.Show("Please enter a valid User ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            RandomizedTextBoxLicenseKey.Text = RandomizedFunctionGenerateLicenseKey(RandomizedTextBoxUserId.Text)
        Catch ex As Exception
            MessageBox.Show("An error occurred during the license key generation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function RandomizedFunctionGenerateLicenseKey(RandomizedUserIdString As String) As String
        Try
            Dim ngwh4h5rtg() As String = RandomizedUserIdString.Split(New String() {"_"}, StringSplitOptions.RemoveEmptyEntries)
            If ngwh4h5rtg.Length < 2 Then
                Throw New ArgumentException("User ID must contain an underscore with multiple parts.")
            End If

            ' اختيار النص بناءً على الراديو بوتون
            Dim keySuffix As String
            If Form1.RadioButton3.Checked Then
                keySuffix = "3losh"     ' الراديو الثالث
            Else
                keySuffix = "AsyncRAT" ' الراديو الأول أو الثاني
            End If

            ' تكوين النص المراد عمل MD5 عليه
            Dim ngwrtg As String = ngwh4h5rtg(1) & ngwh4h5rtg(1) & keySuffix
            Dim ghnjmeg24j3eg() As Byte = RandomizedComputeMD5Hash(ngwrtg)

            Dim ggnbrtgbbdfshgwf(31) As Byte

            ' تقسيم المصفوفة بناءً على اختيار الراديو بوتون
            If Form1.RadioButton1.Checked Then
                ' المثال القديم لراديو بوتون 1
                Array.Copy(ghnjmeg24j3eg, 0, ggnbrtgbbdfshgwf, 0, 5)
                Array.Copy(ghnjmeg24j3eg, 0, ggnbrtgbbdfshgwf, 10, 5)

            ElseIf Form1.RadioButton2.Checked Then
                ' المثال القديم لراديو بوتون 2
                Array.Copy(ghnjmeg24j3eg, 0, ggnbrtgbbdfshgwf, 0, 15)
                Array.Copy(ghnjmeg24j3eg, 0, ggnbrtgbbdfshgwf, 15, 16)

            ElseIf Form1.RadioButton3.Checked Then
                ' إذا أردت نفس أسلوب راديو بوتون 1 أو 2 أو حتى قسم جديد خاص بك:
                ' هنا مثلاً نستخدم نفس أسلوب الراديو الأول كمثال:
                Array.Copy(ghnjmeg24j3eg, 0, ggnbrtgbbdfshgwf, 0, 5)
                Array.Copy(ghnjmeg24j3eg, 0, ggnbrtgbbdfshgwf, 10, 5)

                ' أو يمكنك وضع أسلوب مختلف حسب احتياجك

            Else
                Throw New ArgumentException("Please select an option.")
            End If

            ' إجراء التشفير
            Using gggbbdfshgwf As New RijndaelManaged()
                gggbbdfshgwf.Key = ggnbrtgbbdfshgwf
                gggbbdfshgwf.Mode = CipherMode.ECB
                gggbbdfshgwf.Padding = PaddingMode.PKCS7

                Using ghnbvffgn124jmeg24j3eg As ICryptoTransform = gggbbdfshgwf.CreateEncryptor()
                    Dim ghnbvffgnjmeg24j3eg() As Byte = RandomizedConvertToByteArray(RandomizedUserIdString)
                    Dim ggggvnggffashgwf() As Byte = ghnbvffgn124jmeg24j3eg.TransformFinalBlock(ghnbvffgnjmeg24j3eg, 0, ghnbvffgnjmeg24j3eg.Length)
                    Return Convert.ToBase64String(ggggvnggffashgwf)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred during the encryption process: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function



    Public Shared Function RandomizedComputeMD5Hash(gggggg As String) As Byte()
        Try
            If String.IsNullOrEmpty(gggggg) Then
                Throw New ArgumentException("Input string for MD5 hash cannot be empty.")
            End If

            Using ggggggfhgwf As MD5 = MD5.Create()
                Return ggggggfhgwf.ComputeHash(Encoding.UTF8.GetBytes(gggggg))
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while computing the MD5 hash: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New Byte() {}
        End Try
    End Function

    Public Shared Function RandomizedConvertToByteArray(ggggvnggfhgwf As String) As Byte()
        Try
            If String.IsNullOrEmpty(ggggvnggfhgwf) Then
                Throw New ArgumentException("Input text for byte conversion cannot be empty.")
            End If

            Return Encoding.UTF8.GetBytes(ggggvnggfhgwf)
        Catch ex As Exception
            MessageBox.Show("An error occurred during byte array conversion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New Byte() {}
        End Try
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://t.me/MONSTERMC")
    End Sub
End Class
