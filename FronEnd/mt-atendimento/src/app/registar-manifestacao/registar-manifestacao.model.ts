class  RegistarManifestacao{
	
		public Assunto?: string
		public Mensagem?: string
		public NumeroProtocolo?: string

		public limpar(){
			this.Assunto = "";
			this.Mensagem = "";
		}
	}

export { RegistarManifestacao}