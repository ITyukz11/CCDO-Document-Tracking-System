Imports System.Deployment.Application
Public NotInheritable Class SplashScreen




    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else

            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If


        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        'Dim versions As Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
        ' Version.Text = String.Format("{0}.{1}.{2}.{3}", versions.Major, versions.Minor, versions.Build, versions.Revision)

        Version.Text &= Space(1) & "Hulat Kadali"

        Copyright.Text = My.Application.Info.Copyright
        Copyright.Text &= vbNewLine & "Created by: YJ Koopinoy Corporation"
    End Sub


End Class
