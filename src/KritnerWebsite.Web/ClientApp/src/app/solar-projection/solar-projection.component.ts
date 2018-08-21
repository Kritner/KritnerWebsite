import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-solar-projection',
  templateUrl: './solar-projection.component.html'
})
export class SolarProjectionComponent {
  public solarProjection: SolarProjection;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<SolarProjection>(baseUrl + 'api/SolarProjection/GetProjection').subscribe(result => {
      this.solarProjection = result;
    }, error => console.error(error));
  }
}

interface SolarProjection {
  solarEstimate: YearlyElectricityUsage;
  futureProjection: FutureProjection[];
}

interface YearlyElectricityUsage {
  averageCostKiloWattHour: number;
  averageCostPerMonth: number;
  totalCost: number;
  totalKiloWattHours: number;
}

interface FutureProjection {
  solarEstimate: YearlyElectricityUsage;
  purchaseYear: number;
  averageCostKiloWattHour: number;
  averageCostPerMonth: number;
  totalCost: number;
  totalKiloWattHours: number;

  costSolar100Percent: number;
  costSolar90Percent: number;
  costSolar80Percent: number;
}
