Using System;
Using System.Collections.Generic;
Using System.ComponentModel;
Using System.Data;
Using System.Drawing;
Using System.Linq;
Using System.Text;
Using System.Threading.Tasks;
Using System.Windows.Forms;


		{
			bool teste;
			teste = testaletra("B");
			If (teste == False)
			{
				lblBErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmC_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("C");
			If (teste == False)
			{
				lblCErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmE_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("E");
			If (teste == False)
			{
				lblEErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmF_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("F");
			If (teste == False)
			{
				lblFErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmL_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("L");
			If (teste == False)
			{
				lblLErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmM_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("M");
			If (teste == False)
			{
				lblMErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmN_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("N");
			If (teste == False)
			{
				lblNErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}

		Private void btmR_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("R");
			If (teste == False)
			{
				lblRErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				

		}

		Private void btmU_Click(Object sender, EventArgs e)
		{
			bool teste;
			teste = testaletra("U");
			If (teste == False)
			{
				lblUErrado.Visible = true;
				contaerro++;
				montapessoa();
			}
				
		}



		Private bool testaletra(String letra)
		{
			int tamMaca = 4, tamBanana = 6, tamCelular = 7;

			If (gpbMaca.Visible == True)
			{
				If (lblM.Text == letra)
				{
					lblM.Visible = true;
					contaLetra++;
					Return True;
				}
				

				If (lblA.Text == letra)
				{
					lblA.Visible = true;
					lblA_Maca.Visible = true;
					contaLetra += 2;
					Return True;
				}
				

				If (lblC.Text == letra)
				{
					lblC.Visible = true;
					contaLetra++;
					Return True;
				}
				If (contaLetra == tamMaca)
				{
					MessageBox.Show("Parabéns! Palavra Completada", "Jogo da Forca", MessageBoxButtons.OK);
					gpbMaca.Visible = false;
					gpbBanana.Visible = true;
					contaLetra = 0;
					Return True;

				}
				Return False;
				
			}
			
			If (gpbBanana.Visible == True)
			{
				If (lblABan.Text == letra)
				{
					lblA_bAnana.Visible = true;
					lblBananA.Visible = true;
					lblABan.Visible = true;
					contaLetra += 3;
					Return True;

				} 
				

				If (lblNBan.Text == letra)
				{
					lblNBan.Visible = true;
					lblN_baNana.Visible = true;
					contaLetra += 2;
					Return True;
					
				} else
				

				If (lblB_Banana.Text == letra)
				{
					lblB_Banana.Visible = true;
					contaLetra++;
					Return True;
				}
				If (gpbBanana.Visible == True && contaLetra == tamBanana)
				{
					MessageBox.Show("Parabéns! Palavra Completada", "Jogo da Forca", MessageBoxButtons.OK);
					gpbMaca.Visible = false;
					gpbBanana.Visible = false;
					gpbCelular.Visible = true;
					contaLetra = 0;
					Return True;

				}
				Return False;

			}
			If (gpbCelular.Visible == True)
			{
				If (lblCCelular.Text == letra)
				{
					lblCCelular.Visible = true;
					contaLetra++;
					Return True;
				}
				If (lblE.Text == letra)
				{
					lblE.Visible = true;
					contaLetra++;
					Return True;
				}
				If (lblLCelular.Text == letra)
				{
					lblL.Visible = true;
					lblLCelular.Visible = true;
					contaLetra += 2;
					Return True;
				}
				If (lblACelular.Text == letra)
				{
					lblACelular.Visible = true;
					contaLetra++;
					Return True;
				}
				If (lblR.Text == letra)
				{
					lblR.Visible = true;
					contaLetra++;
					Return True;
				}
				If (lblU.Text == letra)
				{
					lblU.Visible = true;
					contaLetra++;
					Return True;
				}
				If (gpbCelular.Visible == True && contaLetra == tamCelular)
				{
					MessageBox.Show("Parabéns! Palavra Completada", "Jogo da Forca", MessageBoxButtons.OK);
					gpbMaca.Visible = false;
					gpbBanana.Visible = false;
					gpbCelular.Visible = false;
					contaLetra = 0;
					Return True;
				}
				Return False;
			}
	
			Return True;
				
		}
		Private Async void encerraAsync ()
		{
			await Task.Delay(500);
			Frm2 novaform = New Frm2();
			novaform.Show();
			


		}
		Private void montapessoa ()
		{
			If (contaerro == 1)
				lblCabeca.Visible = true;
			If (contaerro == 2)
				picCorpo.Visible = true;
			If (contaerro == 3)
				picBracoEs.Visible = true;
			If (contaerro == 4)
				picBracoDi.Visible = true;
			If (contaerro == 5)
				picPernaEs.Visible = true;
			If (contaerro == 6)
			{
				picPernaDi.Visible = true;
				lblOlhos.Visible = true;
				encerraAsync();
			}
				
		}

	}
}

