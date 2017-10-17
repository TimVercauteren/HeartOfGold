import { Injectable } from '@angular/core'
import { Http, Response, Headers, RequestOptions } from '@angular/http'
import { Observable } from 'rxjs/Observable'
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import { Configuration } from '../../../app/settings'
import { IApplication } from './application'

@Injectable()
export class ApplicationService {
    private baseUrl = this.config.ApiUrl + 'applications';

    constructor(private http: Http, private config: Configuration) { }

    getApplications(): Observable<IApplication[]> {
        return this.http.get(this.baseUrl)
            .map(this.extractData)
            .do(data => console.log('getProducts ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    getApplication(id: number): Observable<IApplication> {

        if (id === 0) {
            return Observable.create((observer: any) => {
                observer.next(this.initializeApplication());
                observer.complete();
            });
        }

        const url = `${this.baseUrl}/${id}`;
        return this.http.get(url)
            .map(this.extractData)
            .do(data => console.log('getProduct ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    saveApplication(application: IApplication): Observable<IApplication> {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });

        if (application.id === 0) {
            return this.createApplication(application, options);
        }
        return this.updateApplication(application, options);
    }

    deleteApplication(id: number): Observable<Response> {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });

        const url = `${this.baseUrl}/${id}`;
        return this.http.delete(url, options)
            .do(data => console.log('deleteApplication: ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    private createApplication(application: IApplication, options: RequestOptions): Observable<IApplication> {
        application.id = 0;
        return this.http.post(this.baseUrl, application, options)
            .map(this.extractData)
            .do(data => console.log('createApplication: ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    private updateApplication(application: IApplication, options: RequestOptions): Observable<IApplication> {
        const url = `${this.baseUrl}/${application.id}`;
        return this.http.put(url, application, options)
            .map(() => application)
            .do(data => console.log('updateProduct: ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    private extractData(response: Response) {
        let body = response.json;
        return body.data || {};
    }

    private handleError(error: Response): Observable<any> {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }

    initializeApplication(): IApplication {

        return {
            id: 0,
            name: '',
            description: '',
            firstInUse: new Date(),
            manufacturer: '',
            numberOfUsers: 0,
            budgetOwner: ''
        };
    }
}
