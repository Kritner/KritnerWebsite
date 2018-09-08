import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SolarProjectionFormModel } from './solar-projection-form-model';

@Component({
  selector: 'app-solar-projection',
  templateUrl: './solar-projection.component.html',
  styleUrls: ['./solar-projection.component.css']
})
export class SolarProjectionComponent implements OnInit {
  isExpandedForm: boolean = true;
  submitted : boolean = false;
  solarProjection: SolarProjection;
  model: SolarProjectionFormModel =
    new SolarProjectionFormModel(
      25,
      17000,
      180,
      20,
      2400,
      .03
    );
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<SolarProjection>(baseUrl + 'api/SolarProjection/GetProjection').subscribe(result => {
      this.solarProjection = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

  inTheGreen(value: number): boolean{
    if (value >= 0)
    {
      return true;
    }

    return false;
  }

  toggleFormInput() {
    this.isExpandedForm = !this.isExpandedForm;
  }

  onSubmit() {
    this.toggleFormInput();
    this.submitted = true;
  }
}

interface SolarProjection {
  solarEstimate: YearlyElectricityUsage;
  futureProjection: FutureProjection[];
  financeYears: number;
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
  totalSavings100Percent: number;
  
  costSolar90Percent: number;
  totalSavings90Percent: number;

  costSolar80Percent: number;
  totalSavings80Percent: number;
}
