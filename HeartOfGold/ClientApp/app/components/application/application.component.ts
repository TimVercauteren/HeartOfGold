import { Component, OnInit } from '@angular/core'
import { IApplication } from './application'
import { ApplicationService} from './application.service'
import { FormGroup, FormBuilder } from '@angular/forms'
import { ActivatedRoute, Router} from '@angular/router'

import {Observable} from 'rxjs/Observable'
import {Subscription} from 'rxjs/Subscription'


@Component({
    selector: 'application',
    templateUrl: './application.component.html',
    providers: [ApplicationService]
})

export class ApplicationComponent implements OnInit {
    applicationForm: FormGroup;
    errorMessage : string;
    application: IApplication;
    private sub : Subscription;

    constructor(private fb: FormBuilder, 
                private route: ActivatedRoute, 
                private router: Router, 
                private applicationService: ApplicationService) {

    }

    ngOnInit(): void {
        this.applicationForm = this.fb.group({
            name: '',
            description: '',
            firstInUse: '',
            manufacturer: '',
            numberOfUsers: '',
            budgetOwner: ''
        });
    }

    //with test data -- add service later
    populateForm() {
        let id = 1; //later from input
        this.getApplication(id)

        this.applicationForm.patchValue({
            
        })
    }

    //save to console for now -- add service later
    save() {
        if (this.applicationForm.dirty && this.applicationForm.valid) {

            //populate the application object
            let a = Object.assign({}, this.application, this.applicationForm.value);
            //use a service to send it to the backend API
            this.applicationService.saveApplication(a)
                .subscribe(
                    () => alert("De gegevens zijn opgeslagen"),
                    (error:any) => this.errorMessage = <any>error
                );
        }
        else {
            alert("Niets gesaved, er is niets aangepast");
        }
    }

    getApplication(id:number): void{
        this.applicationService.getApplication(id)
                .subscribe(
                    (application: IApplication) => this.onAppRetrieved(application),
                    (error: any) => this.errorMessage = <any>error
                )
    }

    onAppRetrieved(application: IApplication): void{
        if (this.applicationForm){
            this.applicationForm.reset();
        }
        this.application = application;

        this.applicationForm.patchValue({
            name: this.application.name,
            description: this.application.description,
            firstInUse : this.application.firstInUse,
            manufacturer : this.application.manufacturer,
            budgetOwner : this.application.budgetOwner,
            numberOfUsers : this.application.numberOfUsers
        });
    }

    deleteProduct(): void{
        if (confirm('WARNING: ALL DATA ENTERED WILL BE LOST, AND YOU MUST START OVER!')){
            this.applicationService.deleteApplication(this.application.id)
                .subscribe(
                    () => this.applicationForm.reset,
                    (error:any) => this.errorMessage = <any>error
                );
        }
    }
}