pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
				sh 'docker build -t tztest .'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
				sh 'docker run --rm tztest'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}