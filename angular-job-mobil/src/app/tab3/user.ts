export class User {
    constructor(
        public email: string,
        public prenom: string,
        public nom: string,
        public mdp: string,
        public phone: string,
        public iam: string,
        public adresse: string,
        public presentation: string,
        //Bricolage
        public meubles: boolean,
        public menuisier: boolean,
        public beton: boolean,
        public papier: boolean,
        public joints: boolean,
        public electronique: boolean,
        //mecanique
        public monter: boolean,
        public vidange: boolean,
        public moteur: boolean,
        public pneus: boolean,
        public carrosserie : boolean,
    ){}
}
