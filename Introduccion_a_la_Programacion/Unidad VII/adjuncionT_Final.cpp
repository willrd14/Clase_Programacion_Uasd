struct cuenta
{
	char codigo[20] = {'\0'};
	char codigo_padre[20] = {'\0'};
	char nombre[80] = {'\0'};
	unsigned short int origen = 0; // 1 - debito 2 - credito
	char es_control = '\0'; // s/n
	char permite_saldo_negativo = '\0'; // s/n
	double saldo = 0;
}

void adicionar()
{
	ofstream archivo_out("registro_cuentas_contables.bin", ios::binary | ios::app);
	ifstream archivo_in("registro_cuentas_contables.bin", ios::binary | ios::in);
	archivo_out.close();
	archivo_in.close();
		int num_cuentas;
		num_cuentas = getNUMcuentas();
		int bytes;
		cuenta cuenta0;
		cuenta cuenta_aux;
		int c = 0, n = 1, k = 0;
		bool condition;
		bool condition_cuenta;
		do
		{
			k = 0;
			condition_cuenta = false;
			condition = false;
			cout << "Codigo de cuenta: ";
			cin.getline(cuenta0.codigo, 20);
			string tmp_string(cuenta0.codigo);
			if(tmp_string.at(0) == '.' || tmp_string.at(tmp_string.size() - 1) == '.')
			{
				cout << "Codigo de cuenta invalido.\nSolo se permite numeros y puntos.\nLos puntos no pueden ser consecutivos ni puden estar al principio o final.\n";
				condition = true;
			}
			for(int i = 0; i < tmp_string.size(); i++)
			{
				if(!(isdigit(tmp_string.at(i)) || tmp_string.at(i) == '.'))
				{
					cout << "Codigo de cuenta invalido. Solo se permite numeros y puntos. Los puntos no pueden ser consecutivos.\n";
					condition = true;
				}
			}			
		archivo_in.open("registro_cuentas_contables.bin", ios::binary | ios::in);
		archivo_in.seekg(ios::beg);
		while(!archivo_in.eof())
		{
			archivo_in.read((char*)&cuenta_aux, sizeof(cuenta_aux));
			if(tmp_string == cuenta_aux.codigo)
			{
				k++;
				condition_cuenta = true;
			}
		}
		if(k>0)
			cout << "Esta cuenta ya existe.\n";
		
		archivo_in.close();
		}while(condition||condition_cuenta);
		k=0;
		
		cout << "Nombre: ";
		cin.getline(cuenta0.nombre,80);
		
		bool condition_padre;
		do
		{
			condition_padre = true;
			condition = false;
			cout << "Codigo de  cuenta padre: ";
			cin.getline(cuenta0.codigo_padre,20);
			string tmp_string(cuenta0.codigo_padre);
			if (tmp_string == "\0")
			{
				condition_padre = false;
				condition = false;
			}else{
				if (tmp_string.at(0) == '.' || tmp_string.at(tmp_string.size()-1) == '.')
				{
					cout << "Codigo de cuenta invalido.\nSolo se permite numeros y puntos.\nLos puntos no pueden ser consecutivos ni puden estar al principio o final.\n";
					condition = true;
				}
			}
			for()
		}
}
