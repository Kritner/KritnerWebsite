export class SolarProjectionFormModel {

    constructor(
        public yearsToProject: number,
        public utilitySolarArrayKwhYear: number,
        public solarCostPerMonth: number,
        public solarFinanceYears: number,
        public utilityCostFullYear: number,
        public utilityPercentIncreasePerYear: number
    ) { }
}
