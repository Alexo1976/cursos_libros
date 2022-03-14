/* CAplicacion.java */

// package Cap01.EstructuraApp;

/* @author Enmanuelle Acuna
 * @version 1.0
*/
public class CAplicacion extends javax.swing.JFrame
{
    public CAplicacion()
    {
        setSize(300, 200);
        setTitle("Aplicación");
        initComponents();
    }

    private void initComponents()
    {
        addWindowListener(new java.awt.event.WindowAdapter()
        {
            public void windowClosing(java.awt.event.WindowEvent evt)
            {
                exitForm(evt);
            }
        }
        );
    }

    private void exitForm(java .awt.event.WindowEvent evt){
        System.exit(0);
    }

    public static void main(String[] args)
    {
        new CAplicacion().setVisible(true);
    }
}

