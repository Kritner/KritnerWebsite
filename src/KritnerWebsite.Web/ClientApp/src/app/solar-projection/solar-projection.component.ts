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
  bgeFutureProjection: ProjectionMap;
}

interface ProjectionMap {
  year: number;
  solarProjection: YearlyElectricityUsage;
}

interface YearlyElectricityUsage {
  averageCostKiloWattHour: number;
  averageCostPerMonth: number;
  totalCost: number;
  totalKiloWattHours: number;
}
